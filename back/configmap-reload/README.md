<<<<<<< HEAD
# 比目鱼

> ### 警告：
>
> 比目鱼（前资源搜索助手）是由 **木鱼(iFish)** 于 2014-2015 年发起并维护的一个免费软件，
> 定位于开发出一个综合各大搜索引擎的搜索工具。  
> 后由于工信部叫停，停止维护，现在重新开源出来。
>
> **请注意**：所有代码均不再维护，仅供交流学习使用。  
> 由于代码属于比较早期的作品，请留意相关技术的正确与否不做保证，请自行鉴别。

一个开源的 BT 综合搜索引擎

## 项目概况

- 开发语言：C#
- 开发平台：VS2019/.NET 4.5

本程序依赖第三方商业列表控件 [Better ListView](http://www.componentowl.com/better-listview.html)，由于版权问题这里不提供此依赖库的详细信息和任何文件，请自行下载试用版安装。

## 项目说明

| 项目                           | 说明                                                                       |
| ------------------------------ | -------------------------------------------------------------------------- |
| `BRG`                          | 基础项目，包含大部分接口定义和实体定义                                     |
| `BRG.DB`                       | 数据库项目，包含了对`SQLite`数据库的访问服务，使用`Dapper`作为实体转换工具 |
| `BRG.Engines`                  | 搜索引擎基础框架                                                           |
| `BRG.Engines.BuildIn`          | 内置的各种搜索引擎，引擎分析使用`HtmlAgilityPack`或`Jumony`进行解析        |
| `BRG.Security`                 | 安全监测模块，用于粗略自动检测资源可靠性                                   |
| `BtResourceGrabber`            | 主程序 GUI 界面                                                            |
| `BRT.CommonPaste.Plugin`       | 一个简单的信息复制插件                                                     |
| `BRT.DownloadConnector.Plugin` | 一个用于使用其它下载工具下载的插件                                         |

> **代码不再维护，引擎可能无法使用，请不要提关于此类的 ISSUE，仅供技术交流使用**

## 关于作者

- **木鱼**
- 博客： https://blog.fishlee.net/
- 微博： https://weibo.com/imcfish/
=======
# Kubernetes ConfigMap Reload

[![license](https://img.shields.io/github/license/jimmidyson/configmap-reload.svg?maxAge=2592000)](https://github.com/jimmidyson/configmap-reload)
[![Docker Stars](https://img.shields.io/docker/stars/jimmidyson/configmap-reload.svg?maxAge=2592000)](https://hub.docker.com/r/jimmidyson/configmap-reload/)
[![Docker Pulls](https://img.shields.io/docker/pulls/jimmidyson/configmap-reload.svg?maxAge=2592000)](https://hub.docker.com/r/jimmidyson/configmap-reload/)
[![Dependency Status](https://dependencyci.com/github/jimmidyson/configmap-reload/badge)](https://dependencyci.com/github/jimmidyson/configmap-reload)
[![CircleCI](https://img.shields.io/circleci/project/jimmidyson/configmap-reload.svg?maxAge=2592000)](https://circleci.com/gh/jimmidyson/configmap-reload)

**configmap-reload** is a simple binary to trigger a reload when Kubernetes ConfigMaps are updated.
It watches mounted volume dirs and notifies the target process that the config map has been changed.
It currently only supports sending an HTTP request, but in future it is expected to support sending OS
(e.g. SIGHUP) once Kubernetes supports pod PID namespaces.

It is available as a Docker image at https://hub.docker.com/r/jimmidyson/configmap-reload

### Usage

```
Usage of ./out/configmap-reload:
  -volume-dir value
        the config map volume directory to watch for updates; may be used multiple times
  -webhook-method string
        the HTTP method url to use to send the webhook (default "POST")
  -webhook-status-code int
        the HTTP status code indicating successful triggering of reload (default 200)
  -webhook-url string
        the url to send a request to when the specified config map volume directory has been updated
  -webhook-retries integer
        the amount of times to retry the webhook reload request
```

### License

This project is [Apache Licensed](LICENSE.txt)

>>>>>>> 306e52eb38809d3b3bf7b7fbc0fd76514f2dac63
