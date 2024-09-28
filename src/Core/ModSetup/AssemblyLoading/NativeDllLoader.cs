using System;
using System.Runtime.InteropServices;

namespace ModName.Core.ModSetup.AssemblyLoading;

public static class NativeDllLoader
{
    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr LoadLibrary(string dllToLoad);

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool FreeLibrary(IntPtr hModule);

        
    public static IntPtr LoadNativeLibrary(string dllPath)
    {
        var hModule = LoadLibrary(dllPath);
        if (hModule == IntPtr.Zero)
            throw new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error(), "Failed to load native DLL: " + dllPath);
            
        return hModule;
    }

    public static void UnloadNativeLibrary(IntPtr hModule) => FreeLibrary(hModule != IntPtr.Zero ? hModule : IntPtr.Zero);
}