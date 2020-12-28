![ElegyRAT-C-Sharp](https://s3.ax1x.com/2020/12/28/roaJts.png)

# ElegyRAT-C-Sharp

### README [English](README.md) | 中文

ElegyRAT是一个远程访问工具（基于[AsyncRAT](https://github.com/NYAN-x-CAT/AsyncRAT-C-Sharp))通过一个安全的加密系统来远程监视和控制其他计算机连接。我主要重写任务启动项和单个插件，以方便绕过AV静态查杀和行为拦截【截止20201231，目前绕过360杀毒 火绒 卡巴斯基 微软defender 等系列杀毒软件（其他未测试），仅供学习研究，请勿用于非法目的。】



# 包括的项目



##### 本项目包括以下内容



-发送和接收命令的插件系统

-控制客户端的接入终端

-可配置客户端可通过终端管理

-记录所有重要事件的日志服务器



##### 特点包括：



-客户端屏幕查看器和记录器

-客户端防病毒和完整性管理器

-客户端SFTP访问，包括上传和下载

-客户端和服务器聊天窗口

-客户端动态DNS和多服务器支持（可配置）

-客户端浏览器密码读取

-客户端JIT编译器

-客户端键盘记录器

-客户端反分析（可配置）

-服务器控制的更新

-客户端反恶意软件启动

-服务器配置编辑器

-服务器多端口接收器（可配置）

-服务器缩略图

-服务器二进制生成器（可配置）

-服务器模糊处理器（可配置）

-还有更多！



### 技术细节



此项目中使用了以下联机服务器/资源

- [pastebin.com] - 用于客户端生成器中的“PasteBin”选项
- [github.com] - 用于下载和上载对项目的更改



### 安装和部署

EleyRAT需要[.Net Framework](microsoft.net/https://netframework.com/download)要运行的v4（Client）和v4.6+（Server）。

```
-要编译此项目，需要visual studio 2019或更高版本

```



### 插件



目前该程序使用了几个集成的DLL（请参阅下面的详细信息）

| Plugin     | Source                        |
| ---------- | ----------------------------- |
| StealerLib | [gitlab.com/thoxy/stealerlib] |



### 下载

[ElegyRAT-C-Sharp/releases](https://github.com/zhaoweiho/ElegyRAT-C-Sharp/releases)



### 你是C或.Net开发人员，想参与吗？



太好了！



请先通读这个项目，了解程序的结构，然后用你自己的更改创建一个fork，然后创建一个pull请求，以及一个引用您所更改的内容、为什么要更改它以及为什么/如果您认为应该实现它的问题



### 法律免责声明请阅读！



##### 本人，创作者和所有与本程序的开发和生产相关的人员对本软件引起的任何行为和/或损害概不负责。您对自己的行为承担全部责任，并承认本软件仅用于教育目的。本软件的预期用途不是恶意使用，也不是在您没有自己的或没有明确权限在其上操作和使用本程序的任何系统上使用。使用此软件，您将自动同意上述内容。



## License

[![License](https://camo.githubusercontent.com/e754645b75702ffcc623fb15d15bd88c0d988ee8a304791fc009ce45268faed6/687474703a2f2f696d672e736869656c64732e696f2f3a6c6963656e73652d6d69742d626c75652e7376673f7374796c653d666c61742d737175617265)](https://github.com/NYAN-x-CAT/AsyncRAT-C-Sharp/blob/master/LICENSE) This project is licensed under the MIT License - see the [LICENSE](https://github.com/NYAN-x-CAT/AsyncRAT-C-Sharp/blob/master/LICENSE) file for details
