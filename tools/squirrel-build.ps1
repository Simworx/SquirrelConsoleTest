param( [Parameter(Mandatory=$true)] $Version )

# find Squirrel.exe path and add an alias
Set-Alias Squirrel ($env:USERPROFILE + "\.nuget\packages\clowd.squirrel\2.8.40\tools\Squirrel.exe");

# build new version and delta updates.
Squirrel pack `
 --framework net6.0.2 `
 --packId "SquirrelConsoleTest" `
 --packVersion $Version `
 --packAuthors "Simworx" `
 --packDirectory "build\net6.0\" `
 --releaseDir "releases\net6.0\" `
 --icon "resources\app.ico"