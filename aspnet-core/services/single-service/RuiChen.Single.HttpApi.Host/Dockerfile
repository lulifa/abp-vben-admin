﻿FROM mcr.microsoft.com/dotnet/aspnet:9.0
LABEL maintainer="lu.lifa@163.com"
WORKDIR /app

COPY . /app

#东8区
ENV TZ=Asia/Shanghai
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo '$TZ' > /etc/timezone

EXPOSE 80/tcp
VOLUME [ "./app/blobs" ]
VOLUME [ "./app/Logs" ]

RUN apt update
RUN apt install wget -y

ENTRYPOINT ["dotnet", "RuiChen.Single.HttpApi.Host.dll"]
