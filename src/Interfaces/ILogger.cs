namespace ModName.Interfaces;

public interface ILogger
{
    void Log(object log);
    void LogError(object log);
    void LogWarning(object log);
}