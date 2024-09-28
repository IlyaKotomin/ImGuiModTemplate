using ImGuiNET;
using ModName.Interfaces;

namespace ModName.LogSystem.Loggers;

public class ImGuiLogger : ILogger
{
    // Log a general message
    public void Log(object log) => LogMessage($"[MOD LOG] {log}");

    // Log an error message
    public void LogError(object log) => LogMessage($"[MOD ERROR] {log}");

    // Log a warning message
    public void LogWarning(object log) => LogMessage($"[MOD WARNING] {log}");

    // Helper method to log messages
    private static void LogMessage(string message) => ImGui.DebugLog($"{message}\n"); // Log the message directly
}