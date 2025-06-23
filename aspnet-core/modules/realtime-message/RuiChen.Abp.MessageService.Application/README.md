# RuiChen.Abp.MessageService.Application

消息服务应用层模块。

## 功能特性

* 实现消息服务的应用层接口
* 实现消息服务的业务逻辑
* 支持自动对象映射

## 依赖模块

* [RuiChen.Abp.MessageService.Application.Contracts](../RuiChen.Abp.MessageService.Application.Contracts/README.md)
* [RuiChen.Abp.MessageService.Domain](../RuiChen.Abp.MessageService.Domain/README.md)

## 配置使用

1. 首先，需要安装 RuiChen.Abp.MessageService.Application 到你的项目中：

```bash
dotnet add package RuiChen.Abp.MessageService.Application
```

2. 添加 `AbpMessageServiceApplicationModule` 到你的模块的依赖列表：

```csharp
[DependsOn(typeof(AbpMessageServiceApplicationModule))]
public class YourModule : AbpModule
{
}
```

## 更多

[English document](README.EN.md)
