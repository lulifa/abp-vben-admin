#!/bin/bash
set -e

if [ ! -f ".env" ]; then
  echo "错误：未找到.env配置文件"
  exit 1
fi

source .env

echo "创建目录结构..."

mkdir -p deploy/middleware/{mysql,redis,rabbitmq,tdengine}/{data,conf,logs}
mkdir -p deploy/middleware/elasticsearch/{data,plugins}
mkdir -p deploy/middleware/nginx/{conf.d,ssl,logs}

echo "清理RabbitMQ旧数据卷..."
docker volume rm -f abp-middleware_rabbitmq_data >/dev/null 2>&1 || true

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

echo "生成Nginx基础配置..."

# 生成nginx.conf
cat > deploy/middleware/nginx/nginx.conf <<EOF
worker_processes 1;

events {
    worker_connections 1024;
}

http {
    include       mime.types;
    default_type  application/octet-stream;

    log_format  main  '\$remote_addr - \$remote_user [\$time_local] "\$request" '
                      '\$status \$body_bytes_sent "\$http_referer" '
                      '"\$http_user_agent" "\$http_x_forwarded_for"';

    access_log  /var/log/nginx/access.log  main;

    sendfile        on;
    tcp_nopush     on;
    tcp_nodelay    on;
    keepalive_timeout  65;
    types_hash_max_size 2048;

    include /etc/nginx/conf.d/*.conf;
}
EOF

# 生成默认的 conf.d 配置
cat > deploy/middleware/nginx/conf.d/default.conf <<EOF
server {
    listen 80;
    server_name localhost;

    location / {
        root   /usr/share/nginx/html;
        index  index.html index.htm;
    }

    error_page   500 502 503 504  /50x.html;
    location = /50x.html {
        root   /usr/share/nginx/html;
    }
}
EOF

echo "启动中间件容器（含Nginx）..."
docker compose -f docker-compose.middleware.yml up -d

echo "等待服务初始化..."
sleep 7

echo "验证RabbitMQ管理插件状态..."
if docker exec abp-rabbitmq rabbitmq-plugins list -m | grep -q 'rabbitmq_management.*E'; then
  echo "管理插件已成功启用！"
else
  echo "警告：管理插件未启用 启用插件中..."
  docker exec abp-rabbitmq rabbitmq-plugins enable rabbitmq_management
  sleep 5
fi

echo "启用RabbitMQ MQTT插件..."
docker exec abp-rabbitmq rabbitmq-plugins enable rabbitmq_mqtt
sleep 3

echo "验证Nginx配置..."
if docker exec abp-nginx nginx -t; then
  echo "Nginx配置验证通过！"
else
  echo "警告：Nginx配置错误！请检查 /deploy/nginx/nginx.conf"
  exit 1
fi

echo "中间件部署完成"
docker ps -f name=abp- --format "table {{.Names}}\t{{.Status}}\t{{.Ports}}"

echo "连接信息:"
echo "MySQL:         docker exec -it abp-mysql mysql -uroot -p"
echo "Redis:         docker exec -it abp-redis redis-cli"
echo "RabbitMQ:      docker exec -it abp-rabbitmq rabbitmqctl 或访问 http://localhost:15672"
echo "RabbitMQ MQTT: mqtt://localhost:1883 (用户名密码同RabbitMQ)"
echo "TDengine:      docker exec -it abp-tdengine taos"
echo "Elasticsearch: http://localhost:9200"
echo "Nginx:         http://localhost 或 https://localhost（注意是否配置了 SSL）"
