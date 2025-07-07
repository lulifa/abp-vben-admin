#!/bin/bash
set -e

if [ ! -f ".env" ]; then
  echo "错误：未找到.env配置文件"
  exit 1
fi

source .env

echo "创建目录结构..."

mkdir -p apps/admin/backend
mkdir -p apps/admin/frontend
mkdir -p deploy/middleware/{mysql,redis,rabbitmq,tdengine}/{data,conf,logs}
mkdir -p deploy/middleware/nginx/{conf.d,logs,certs}

echo "清理RabbitMQ旧数据卷..."
docker volume rm -f lulifa-middleware_rabbitmq_data >/dev/null 2>&1 || true

if [ ! -f "deploy/middleware/mysql/conf/my.cnf" ]; then
  echo "生成MySQL基础配置..."
  cat > deploy/middleware/mysql/conf/my.cnf <<EOF
[mysqld]
default_authentication_plugin = mysql_native_password
character-set-server = utf8mb4
collation-server = utf8mb4_general_ci
skip_name_resolve = 1
EOF
fi

# 如果没有配置文件，则生成默认的Nginx配置文件
if [ ! -f "deploy/middleware/nginx/conf.d/default.conf" ]; then
  echo "生成默认的Nginx配置文件..."
  cat > deploy/middleware/nginx/conf.d/default.conf <<EOF
server {
    listen 80;
    server_name www.lulifa.com;

    location / {
        root /usr/share/nginx/html/admin;
        try_files \$uri \$uri/ /index.html;
    }
    
    location /.well-known {
        proxy_pass http://admin-api:80;
        proxy_set_header Host \$host;
        proxy_set_header X-Real-IP \$remote_addr;
    }

    location /api {
        proxy_pass http://admin-api:80;
        proxy_set_header Host \$host;
        proxy_set_header X-Real-IP \$remote_addr;
    }

    location /connect {
        proxy_pass http://admin-api:80;
        proxy_set_header Host \$host;
        proxy_set_header X-Real-IP \$remote_addr;
    }

    location /signalr-hubs {
        proxy_pass http://admin-api:80;
        proxy_http_version 1.1;
        proxy_set_header Upgrade \$http_upgrade;
        proxy_set_header Connection "upgrade";
        proxy_set_header Host \$host;
        proxy_set_header X-Real-IP \$remote_addr;
    }
}
EOF
fi

# 如果没有配置文件lulifa.conf，则生成默认的Nginx配置文件
if [ ! -f "deploy/middleware/nginx/conf.d/lulifa.conf" ]; then
  echo "生成默认的Nginx配置文件lulifa.conf..."
  cat > deploy/middleware/nginx/conf.d/lulifa.conf <<EOF
  
server {
    listen 80;
    server_name music.lulifa.com www.music.lulifa.com;

    location / {
        proxy_pass http://lulifa-yesplay:80;
        proxy_set_header Host \$host;
        proxy_set_header X-Real-IP \$remote_addr;
        proxy_set_header X-Forwarded-For \$proxy_add_x_forwarded_for;
        proxy_set_header X-Forwarded-Proto \$scheme;
    }
}

server {
    listen 80;
    server_name video.lulifa.com www.video.lulifa.com;

    location / {
        proxy_pass http://lulifa-libretv:8080;
        proxy_set_header Host \$host;
        proxy_set_header X-Real-IP \$remote_addr;
        proxy_set_header X-Forwarded-For \$proxy_add_x_forwarded_for;
        proxy_set_header X-Forwarded-Proto \$scheme;
    }
}

server {
    listen 80;
    server_name linux.lulifa.com www.linux.lulifa.com;

    location / {
        proxy_pass http://lulifa-linux-command:80;
        proxy_set_header Host \$host;
        proxy_set_header X-Real-IP \$remote_addr;
        proxy_set_header X-Forwarded-For \$proxy_add_x_forwarded_for;
        proxy_set_header X-Forwarded-Proto \$scheme;
    }
}

server {
    listen 80;
    server_name photo.lulifa.com www.photo.lulifa.com;

    client_max_body_size 200M;

    location / {
        proxy_pass http://lulifa-lychee:80;
        
        proxy_set_header Host \$host;
        proxy_set_header X-Real-IP \$remote_addr;
        proxy_set_header X-Forwarded-For \$proxy_add_x_forwarded_for;
        proxy_set_header X-Forwarded-Proto \$scheme;
        
        proxy_set_header Cookie \$http_cookie;
        proxy_cookie_path / "/; SameSite=Lax";
        charset utf-8;

        proxy_hide_header Content-Security-Policy;
    }
    
    location ~* \.(jpg|jpeg|png|gif|css|js|ico)$ {
        proxy_pass http://lulifa-lychee:80;
        expires 30d;
        add_header Cache-Control "public";

        proxy_hide_header Content-Security-Policy;
    }
}
EOF
fi

echo "启动中间件容器..."
docker compose -f docker-compose.middleware.yml up -d

echo "等待服务初始化..."
sleep 15

echo "验证RabbitMQ管理插件状态..."
if docker exec lulifa-rabbitmq rabbitmq-plugins list -m | grep -q 'rabbitmq_management.*E'; then
  echo "管理插件已成功启用！"
else
  echo "管理插件未启用 启用插件中..."
  docker exec lulifa-rabbitmq rabbitmq-plugins enable rabbitmq_management
  sleep 5
fi

echo "启用RabbitMQ MQTT插件..."
docker exec lulifa-rabbitmq rabbitmq-plugins enable rabbitmq_mqtt
sleep 3

echo "中间件部署完成"
docker ps -f name=lulifa- --format "table {{.Names}}\t{{.Status}}\t{{.Ports}}"

echo "连接信息:"
echo "MySQL:         docker exec -it lulifa-mysql mysql -uroot -p"
echo "Redis:         docker exec -it lulifa-redis redis-cli"
echo "RabbitMQ:      docker exec -it lulifa-rabbitmq rabbitmqctl 或访问 http://www.lulifa.com:15672"
echo "RabbitMQ MQTT: mqtt://www.lulifa.com:1883 (用户名密码同RabbitMQ)"
echo "TDengine:      docker exec -it lulifa-tdengine taos"
echo "Nginx:         http://www.lulifa.com"