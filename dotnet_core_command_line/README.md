# .NET Core on Linux

Attempt to reliably setup and run a C# environment using

* Visual Studio Code
* Roslyn
* Omnisharp
* C# VSCode Extension

Arch Linux install (so far)

```
sudo pacman -Sy vscode-oss dotnet-sdk
```

Further testing is needed and currently getting a signature error for Omnisharp, but the MSBuild and Omnisharp-Roslyn package may be needed from the AUR.