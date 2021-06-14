This C# program prints out the source code of a Node.js program that prints the source of the original C# program.

(It turned out a bit messy, but I'm just a dabbler.)

* Install .NET 5.0 SDK
* Install Node.js

<pre>
C:\csharp-nodejs-quine-relay><b>dotnet build</b>
Microsoft (R) Build Engine version 16.9.0+57a23d249 for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  All projects are up-to-date for restore.
  Quine -> C:\csharp-nodejs-quine-relay\bin\Debug\net5.0\Quine.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:01.01

C:\csharp-nodejs-quine-relay><b>bin\Debug\net5.0\Quine.exe > out.js</b>

C:\csharp-nodejs-quine-relay><b>node out.js > Out.cs</b>

C:\csharp-nodejs-quine-relay><b>FC Program.cs Out.cs</b>
Comparing files Program.cs and OUT.CS
FC: no differences encountered

</pre>
