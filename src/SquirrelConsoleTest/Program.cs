using Squirrel;

if (OperatingSystem.IsWindows())
{
    SquirrelAwareApp.HandleEvents(
        onInitialInstall: OnAppInstall,
        onAppUninstall: OnAppUninstall,
        onEveryRun: OnAppRun);
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void OnAppInstall(SemanticVersion version, IAppTools tools)
{
    if (OperatingSystem.IsWindows())
    {
        tools.CreateShortcutForThisExe(ShortcutLocation.StartMenu | ShortcutLocation.Desktop);
    }
}

static void OnAppUninstall(SemanticVersion version, IAppTools tools)
{
    if (OperatingSystem.IsWindows())
    {
        tools.RemoveShortcutForThisExe(ShortcutLocation.StartMenu | ShortcutLocation.Desktop);
    }
}

static void OnAppRun(SemanticVersion version, IAppTools tools, bool firstRun)
{
    tools.SetProcessAppUserModelId();
}