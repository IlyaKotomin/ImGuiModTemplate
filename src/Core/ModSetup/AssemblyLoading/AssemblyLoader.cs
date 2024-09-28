using System;
using System.IO;
using System.Reflection;
using DuckGame;

namespace ModName.Core.ModSetup.AssemblyLoading;

internal class AssemblyLoader(string sharedDllsPath)
{
    public void LoadAssemblies()
    {
        ModLogger.Log($"Loading assemblies from: {sharedDllsPath}");

        if (!Directory.Exists(sharedDllsPath))
            throw new DirectoryNotFoundException($"Shared DLLs folder not found at: {sharedDllsPath}");

        foreach (var dllPath in Directory.GetFiles(sharedDllsPath, "*.dll")) LoadAssembly(dllPath);
    }

    private void LoadAssembly(string dllPath)
    {
        try
        {
            Assembly.LoadFrom(dllPath);
            ModLogger.Log($"Loaded managed assembly: {dllPath}");
        }
        catch (BadImageFormatException ex)
        {
            ModLogger.LogWarning($"Failed to load managed assembly: {dllPath}. Trying as native DLL. Error: {ex.Message}");
            TryLoadNativeLibrary(dllPath);
        }
        catch (Exception ex)
        {
            ModLogger.LogError($"Error while loading {dllPath}: {ex.Message}");
        }
    }

    private void TryLoadNativeLibrary(string dllPath)
    {
        try
        {
            var handle = NativeDllLoader.LoadNativeLibrary(dllPath);
            ModLogger.Log($"Successfully loaded native library: {dllPath}");
            ModLogger.Log($"Native library handle: {handle}");
        }
        catch (Exception ex)
        {
            ModLogger.LogError($"Failed to load native DLL: {dllPath}. Error: {ex.Message}");
        }
    }
}