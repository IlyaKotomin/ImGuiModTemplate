using DuckGame;
using ImGuiNET;
using Microsoft.Xna.Framework.Graphics;
using ModName.Interfaces;
using Color = DuckGame.Color;
using Vector2 = System.Numerics.Vector2;

namespace ModName.Example;

public class ExampleMenu : IInjectDrawable, IInjectUpdateable
{
    private static bool _showMenu = true;
    private static int _corner;
    private static readonly GraphicsDevice Graphics = MonoMain.instance.GraphicsDevice;

    public ExampleMenu()
    {
        ExampleTheme.SetTheme(); // Set the ImGui theme
        ImGui.GetIO().FontGlobalScale = 2f; // Set the global scale factor to 1.5
    }

    // NOTE: Use "this." every time when you want to access the current instance of any field           !IMPORTANT!
    public void Draw()
    {
        if (!_showMenu) return; // Don't draw the menu if it's hidden

        //ImGui.PushFont(_fontPointer); // Set the font for the ImGui window

        DrawImGuiOverlay(); // Draw the ImGui overlay

        ImGui.ShowDemoWindow(ref _showMenu); // Show the ImGui demo window
        ImGui.ShowDebugLogWindow(ref _showMenu);
        
        DuckGame.Graphics.DrawCircle(Mouse.mousePos, 5f, Color.White, 2f);
    }

    private static void DrawImGuiOverlay()
    {
        var io = ImGui.GetIO();
        const ImGuiWindowFlags windowFlags = ImGuiWindowFlags.NoDecoration | ImGuiWindowFlags.AlwaysAutoResize |
                                             ImGuiWindowFlags.NoSavedSettings | ImGuiWindowFlags.NoFocusOnAppearing |
                                             ImGuiWindowFlags.NoMove;

        if (_corner is >= 0 and < 4)
        {
            //offset X
            var distanceX = _corner is 1 or 3 ? Graphics.Viewport.Width - 250f : 20f;

            //offset Y
            var distanceY = _corner is 2 or 3 ? Graphics.Viewport.Height - 150f : 20f;

            var windowPosition = new Vector2(distanceX, distanceY);
            ImGui.SetNextWindowPos(windowPosition);
        }

        ImGui.SetNextWindowBgAlpha(0.35f);
        if (ImGui.Begin("Example: Simple overlay", windowFlags))
        {
            ImGui.Text(
                "Simple overlay\nin the corner of the screen\n(right-click to change position)\nPress F1 to toggle.");
            ImGui.Separator();

            ImGui.Text(ImGui.IsMousePosValid()
                ? $"Mouse Position: ({io.MousePos.X},{io.MousePos.Y})"
                : "Mouse Position: <invalid>");

            if (ImGui.BeginPopupContextWindow())
            {
                if (ImGui.MenuItem("Top-left", null, _corner == 0)) _corner = 0;

                if (ImGui.MenuItem("Top-right", null, _corner == 1)) _corner = 1;

                if (ImGui.MenuItem("Bottom-left", null, _corner == 2)) _corner = 2;

                if (ImGui.MenuItem("Bottom-right", null, _corner == 3)) _corner = 3;

                ImGui.EndPopup();
            }
        }

        ImGui.End();
    }

    public void Update()
    {
        if (!Keyboard.Pressed(Keys.F1)) return; // Toggle with F1 key

        _showMenu = !_showMenu; // Toggle the menu visibility
        ModLogger.Log("Example menu toggled! Current state: " + _showMenu);
    }
}