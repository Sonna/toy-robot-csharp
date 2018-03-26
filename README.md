# README

Create new project:

```console
$ dotnet new -i nunit
  Restoring packages for /Users/Sonna/.templateengine/dotnetcli/v1.1.8/scratch/restore.csproj...
  Installing runtime.osx.10.10-x64.runtime.native.System.Security.Cryptography.Apple 4.3.0.
  Installing runtime.ubuntu.16.10-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0.
  Installing runtime.rhel.7-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0.
  Installing runtime.ubuntu.14.04-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0.
  Installing runtime.fedora.23-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0.
  Installing runtime.ubuntu.16.04-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0.
  Installing runtime.osx.10.10-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0.
  Installing runtime.debian.8-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0.
  Installing runtime.opensuse.42.1-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0.
  Installing runtime.opensuse.13.2-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0.
  Installing NUnit 3.10.1.
  Installing runtime.fedora.24-x64.runtime.native.System.Security.Cryptography.OpenSsl 4.3.0.
  Installing NETStandard.Library 1.6.1.
  Installing Microsoft.NETCore.Platforms 1.1.0.
  Installing System.Reflection.TypeExtensions 4.3.0.
  Installing System.AppContext 4.3.0.
  Installing System.Reflection.Emit 4.3.0.
  Installing System.ObjectModel 4.3.0.
  Installing System.Reflection.Emit.ILGeneration 4.3.0.
  Installing System.Security.Cryptography.Primitives 4.3.0.
  Installing System.Reflection.Emit.Lightweight 4.3.0.
  Installing System.Runtime.Numerics 4.3.0.
  Installing System.Threading.Tasks.Extensions 4.3.0.
  Installing System.IO.FileSystem.Primitives 4.3.0.
  Installing System.Linq 4.3.0.
  Installing System.Collections.Concurrent 4.3.0.
  Installing System.Text.RegularExpressions 4.3.0.
  Installing System.Globalization.Calendars 4.3.0.
  Installing System.Diagnostics.Tools 4.3.0.
  Installing System.Diagnostics.Debug 4.3.0.
  Installing System.Net.Sockets 4.3.0.
  Installing System.Console 4.3.0.
  Installing Microsoft.Win32.Primitives 4.3.0.
  Installing System.Reflection.Extensions 4.3.0.
  Installing System.Resources.ResourceManager 4.3.0.
  Installing System.IO.FileSystem 4.3.0.
  Installing System.Runtime.Handles 4.3.0.
  Installing System.Reflection.Primitives 4.3.0.
  Installing System.Globalization 4.3.0.
  Installing System.Diagnostics.Tracing 4.3.0.
  Installing System.Reflection 4.3.0.
  Installing System.Collections 4.3.0.
  Installing System.Net.Primitives 4.3.0.
  Installing System.Threading.Timer 4.3.0.
  Installing System.IO 4.3.0.
  Installing System.Text.Encoding.Extensions 4.3.0.
  Installing System.Text.Encoding 4.3.0.
  Installing System.Runtime.InteropServices.RuntimeInformation 4.3.0.
  Installing System.IO.Compression.ZipFile 4.3.0.
  Installing System.IO.Compression 4.3.0.
  Installing System.Security.Cryptography.Encoding 4.3.0.
  Installing System.Security.Cryptography.Algorithms 4.3.0.
  Installing System.Threading 4.3.0.
  Installing System.Runtime.Extensions 4.3.0.
  Installing System.Xml.XDocument 4.3.0.
  Installing System.Threading.Tasks 4.3.0.
  Installing System.Net.Http 4.3.0.
  Installing System.Security.Cryptography.X509Certificates 4.3.0.
  Installing System.Xml.ReaderWriter 4.3.0.
  Installing System.Runtime.InteropServices 4.3.0.
  Installing System.Linq.Expressions 4.3.0.
  Installing System.Runtime 4.3.0.
  Installing Microsoft.NETCore.Targets 1.1.0.
  Installing runtime.native.System 4.3.0.
  Installing System.Buffers 4.3.0.
  Installing runtime.native.System.IO.Compression 4.3.0.
  Installing runtime.native.System.Security.Cryptography.OpenSsl 4.3.0.
  Installing runtime.native.System.Security.Cryptography.Apple 4.3.0.
  Installing runtime.native.System.Net.Http 4.3.0.
  Installing System.Security.Cryptography.OpenSsl 4.3.0.
  Installing System.Diagnostics.DiagnosticSource 4.3.0.
  Installing System.Globalization.Extensions 4.3.0.
  Installing System.Security.Cryptography.Csp 4.3.0.
  Installing System.Security.Cryptography.Cng 4.3.0.
  Generating MSBuild file /Users/Sonna/.templateengine/dotnetcli/v1.1.8/scratch/obj/restore.csproj.nuget.g.props.
  Generating MSBuild file /Users/Sonna/.templateengine/dotnetcli/v1.1.8/scratch/obj/restore.csproj.nuget.g.targets.
  Restore completed in 1.24 min for /Users/Sonna/.templateengine/dotnetcli/v1.1.8/scratch/restore.csproj.


Templates                                         Short Name       Language          Tags
---------------------------------------------------------------------------------------------------
Console Application                               console          [C#], F#, VB      Common/Console
Class library                                     classlib         [C#], F#, VB      Common/Library
Unit Test Project                                 mstest           [C#], F#, VB      Test/MSTest
NUnit 3 Test Project                              nunit            [C#], F#, VB      Test/NUnit
xUnit Test Project                                xunit            [C#], F#, VB      Test/xUnit
ASP.NET Core Empty                                web              [C#], F#          Web/Empty
ASP.NET Core Web App (Model-View-Controller)      mvc              [C#], F#          Web/MVC
ASP.NET Core Web API                              webapi           [C#], F#          Web/WebAPI
global.json file                                  globaljson                         Config
Nuget Config                                      nugetconfig                        Config
Web Config                                        webconfig                          Config
Solution File                                     sln                                Solution


Examples:
    dotnet new mvc --framework netcoreapp1.1 --auth Individual
    dotnet new nunit --framework netcoreapp2.0
    dotnet new --help
```

_After installing NUnit Test Project template_

```console
$ dotnet new nunit
The template "NUnit 3 Test Project" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on /Users/Sonna/Projects/csharp/unit-testing-using-nunit/unit-testing-using-nunit.csproj...
/usr/local/share/dotnet/sdk/1.1.8/Sdks/Microsoft.NET.Sdk/build/Microsoft.NET.TargetFrameworkInference.targets(112,5): error : The current .NET SDK does not support targeting .NET Core 2.0.  Either target .NET Core 1.1 or lower, or use a version of the .NET SDK that supports .NET Core 2.0. [/Users/Sonna/Projects/csharp/unit-testing-using-nunit/unit-testing-using-nunit.csproj]


Restore failed.
Post action failed.
Description: Restore NuGet packages required by this project.
Manual instructions: Run 'dotnet restore'
```

After installing a newer version of DotNet Core (not the Development SDK).

```console
$ dotnet test

Welcome to .NET Core!
---------------------
Learn more about .NET Core @ https://aka.ms/dotnet-docs. Use dotnet --help to see available commands or go to https://aka.ms/dotnet-cli-docs.

Telemetry
--------------
The .NET Core tools collect usage data in order to improve your experience. The data is anonymous and does not include command-line arguments. The data is collected by Microsoft and shared with the community.
You can opt out of telemetry by setting a DOTNET_CLI_TELEMETRY_OPTOUT environment variable to 1 using your favorite shell.
You can read more about .NET Core tools telemetry @ https://aka.ms/dotnet-cli-telemetry.
Build started, please wait...
Build completed.

Test run for /Users/Sonna/Projects/csharp/unit-testing-using-nunit/bin/Debug/netcoreapp2.0/unit-testing-using-nunit.dll(.NETCoreApp,Version=v2.0)
Microsoft (R) Test Execution Command Line Tool Version 15.6.0-preview-20180109-01
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
NUnit Adapter 3.10.0.21: Test execution started
Running all tests in /Users/Sonna/Projects/csharp/unit-testing-using-nunit/bin/Debug/netcoreapp2.0/unit-testing-using-nunit.dll
NUnit3TestExecutor converted 1 of 1 NUnit test cases
NUnit Adapter 3.10.0.21: Test execution complete

Total tests: 1. Passed: 1. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 1.3417 Seconds

```

Compile `Main.cs`

```console
$ csc Main.cs
Microsoft (R) Visual C# Compiler version 2.3.1.61919 (57c81319)
Copyright (C) Microsoft Corporation. All rights reserved.

```

Run `Main.exe`

```console
$ mono Main.exe
Hello World
```

```console
```

## References:
- [core/2\.0\.6\-download\.md at master · dotnet/core]
  (https://github.com/dotnet/core/blob/master/release-notes/download-archives/2.0.6-download.md)


- [docs/samples/core/getting\-started/unit\-testing\-using\-nunit at master · dotnet/docs]
  (https://github.com/dotnet/docs/tree/master/samples/core/getting-started/unit-testing-using-nunit)

- [NuGet Gallery \| dotnet\-test\-nunit 3\.4\.0\-beta\-3]
  (https://www.nuget.org/packages/dotnet-test-nunit/)

- [docs/samples/core/getting\-started/unit\-testing\-using\-dotnet\-test at master · dotnet/docs]
  (https://github.com/dotnet/docs/tree/master/samples/core/getting-started/unit-testing-using-dotnet-test)
