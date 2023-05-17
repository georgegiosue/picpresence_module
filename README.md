# Picpresence Experimental Library 🚀

![Nuget Version](https://img.shields.io/nuget/v/picpresencemodule)
![Downloads](https://img.shields.io/nuget/dt/picpresencemodule)

## Available on NuGet

[<img src="https://learn.microsoft.com/en-us/dotnet/standard/library-guidance/media/nuget/nuget-logo.png" width="200"/>](https://www.nuget.org/packages/picpresencemodule)

## Table of Contents 📚

1. [Description](#description)
2. [Structure](#structure)
3. [Installation](#installation)
4. [Contribution](#contribution)
5. [Troubleshooting](#troubleshooting)
6. [License](#license)

## Description 🖋️

Picpresence Module is a simple module designed to connect PIC16F876 with an LCD LM016L through serial ports connection. This module is written in C# and can be utilized in various applications that require interfacing with the PIC16F876 microcontroller and the LM016L LCD.

<div style="display: flex; justify-content: center;">
  <img src="https://media.discordapp.net/attachments/1011104041880801281/1015132288129970186/unknown.png" width="450"/>
  <img src="https://cdn.discordapp.com/attachments/923769146762727515/1108455786859995146/picpresence.png" width="450"/>
</div>

## Structure 📂
```
├── Core
│   ├── ISerialPort.cs
│   └── SerialPortFlow.cs
├── README.md
├── Utils
│   └── Attach.cs
├── picpresencelib.csproj
└── picpresencelib.sln
```


## Installation 💻

You can install the library via .NET CLI
```bash
dotnet add package picpresencemodule --version 1.1.3
```

## Contribution 🤝

Contributions are always welcome. To contribute:

1. Fork the project.
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`).
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the Branch (`git push origin feature/AmazingFeature`).
5. Open a Pull Request.

## Troubleshooting 🔧

If you encounter any problems while setting up or using the module, please check the [Issues](https://github.com/16george/picpresence_module/issues) section of this repository to see if your issue has already been addressed. If not, feel free to open a new issue with a description of the problem you're experiencing.

## License 📄

```
MIT License

Copyright (c) 2022 George Namoc

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
