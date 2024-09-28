# Duck Game Mod Template

## About this project

This project is a template for creating mods for Duck Game. It provides examples and guidelines to help you get started with mod development, including creating custom themes, menus, and loggers.

## Features
- **Updateable and Drawable classes**: Create custom classes that can be updated and drawn in the game.
- **ImGui menus**: Create custom menus using ImGui.
- **Custom themes**: Create custom themes for ImGui.
- **Custom loggers**: Create custom loggers for logging messages in the game.
- **Shared DLLs**: Add custom libraries to the `Content/SharedDlls` directory to be loaded in the game.

## Getting Started

To get started with your mod, follow these steps:

1. Clone this repository.
2. Open the project in your preferred IDE (e.g., JetBrains Rider).
3. Customize the mod by editing the provided files.

## Adding Custom Libraries

Any custom libraries that you want to use need to be added to the `Content/SharedDlls` directory to be loaded in the game.

All DLLs from this folder, such as `cimgui` and `ImGui.Net`, will be injected into the game.

## Example: Updateable or Drawable class

To create an Updateable or Drawable class, you can follow this example:

```csharp
// ExampleUpdate.cs
namespace ModName.Example;

//Use IInjectUpdateable to inject Updateable classes into the game    
//Use IInjectDrawable to inject Drawable classes into the game
public class ExampleUpdateDraw : IInjectUpdateable, IInjectDrawable
{
    public void Update()
    {
        // Example: Print "Hello, world!" every frame
        ModLogger.Log("Hello, world!");
    }
    
    public void Draw()
    {
        // Example: Draw a red rectangle at position (100, 100) with a size of (50, 50)
        Graphics.DrawRect(100, 100, 50, 50, Color.Red);
    }
}
```

## Example: Creating a Menu

To create a menu using ImGui, you can follow this example:

```csharp
// ExampleMenu.cs
namespace ModName.Menus
{
    public class ExampleMenu : IInjectDrawable //Use IInjectDrawable to inject the menu into the game
    {
        public void Draw()
        {
            ImGui.Begin("Example Menu");
            ImGui.Text("Hello, world!");
            ImGui.End();
        }
    }
}
```

## Example: Creating an ImGui Theme

To create a custom ImGui theme, you can follow this example:

[(Here you can see all colors)](https://github.com/ImGuiNET/ImGui.NET/blob/70a87022f775025b90dbe2194e44983c79de0911/src/ImGui.NET/Generated/ImGuiCol.gen.cs#L5)
```csharp
// ExampleTheme.cs
namespace ModName.Themes
{
    public static class ExampleTheme
    {
        public static void Apply()
        {
            var style = ImGui.GetStyle();
            style.Colors[(int)ImGuiCol.WindowBg] = new System.Numerics.Vector4(0.1f, 0.1f, 0.1f, 1.0f);
            // Customize other style properties as needed
            
            //See my example in the ExampleTheme.cs file
        }
    }
}
```

## Example: Creating Custom Loggers

To create custom loggers and add them to `ModLogger`, you can follow this example:

```csharp
// CustomLogger.cs
using ModName.LogSystem;

namespace ModName.Loggers
{
    public class CustomLogger : ILogger
    {
        // Custom logging logic
        public void Log(object message)
        {
            System.Console.WriteLine($"CustomLogger: {message}");
        }
        
        public void LogWarning(object message)
        {
            System.Console.WriteLine($"CustomLogger WARNING: {message}");
        }
        
        public void LogError(object message)
        {
            System.Console.WriteLine($"CustomLogger ERROR: {message}");
        }
    }
}
```

To add the custom logger to `ModLogger`, you can modify the `InitializeLogging` method in `ModInitialize.cs`:

```csharp
private void InitializeLogging()
{
    ModLogger.Loggers.Add(new DevConsoleLogger("ModName"));
    ModLogger.Loggers.Add(new CustomLogger());
}
```

## Other Examples
See `ExampleUpdate.cs`, `ExampleMenu.cs`, `ExampleTheme.cs`, and `DevConsoleLogger.cs` for more examples.

## License

This project is licensed under the MIT License. See the LICENSE file for details.