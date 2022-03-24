# SquirrelConsoleTest

SquirrelConsoleTest is test app for trying [Clowd.Squirrel](https://github.com/clowd/Clowd.Squirrel) features out.

## Building from source

Prerequisites
- **Must**: .NET 6 SDK
- **Should**: VSCode, Visual Studio 2021 or Rider

Instructions
- Clone the repository
- Run `dotnet publish src\SquirrelConsoleTest\SquirrelConsoleTest.csproj /p:PublishProfile=src\SquirrelConsoleTest\Properties\PublishProfiles\FolderProfile.pubxml` to build and publish the app
- Then run `.\tools\squirrel-build.ps1 1.0.0` to build installer

