using System.Collections.Generic;
using ModName.Interfaces;

namespace ModName.LogSystem;

public static class ModLogger
{
    public static readonly List<ILogger> Loggers = [];
    
    public static void Log(object log) => Loggers.ForEach(logger => logger.Log(log));

    public static void LogError(object log) => Loggers.ForEach(logger => logger.LogError(log));

    public static void LogWarning(object log) => Loggers.ForEach(logger => logger.LogWarning(log));
}