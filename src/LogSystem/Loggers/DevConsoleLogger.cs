using DuckGame;
using ModName.Interfaces;

namespace ModName.LogSystem.Loggers;

public class DevConsoleLogger(string name) : ILogger
{
    public void Log(object log) => DevConsole.Log($"|PURPLE|{name}|WHITE|: {log}");

    public void LogError(object log) => DevConsole.Log($"|PURPLE|{name}|RED| [ERROR]: {log}");

    public void LogWarning(object log) => DevConsole.Log($"|PURPLE|{name}|YELLOW| [WARNING]: {log}");
}