This C# program prints out the source code of a Node.js program that prints the source of the original C# program.

(It turned out a bit messy, but I'm just a dabbler.)

* Install .NET 5.0 SDK
* Install Node.js

```
dotnet build
bin\Debug\net5.0\Quine.exe > out.js
node out.js > Out.cs
FC Program.cs Out.cs
```

```
C:\csharp-nodejs-quine-relay>dotnet build
Microsoft (R) Build Engine version 16.9.0+57a23d249 for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  All projects are up-to-date for restore.
  Quine -> C:\csharp-nodejs-quine-relay\bin\Debug\net5.0\Quine.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:01.01

C:\csharp-nodejs-quine-relay>bin\Debug\net5.0\Quine.exe > out.js

C:\csharp-nodejs-quine-relay>node out.js > Out.cs

C:\csharp-nodejs-quine-relay>FC Program.cs Out.cs
Comparing files Program.cs and OUT.CS
FC: no differences encountered

```
