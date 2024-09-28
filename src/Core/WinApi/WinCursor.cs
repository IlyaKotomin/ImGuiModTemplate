using System.Runtime.InteropServices;

namespace ModName.Core.WinApi;

public static class WinCursor
{
    [DllImport("user32.dll")]
    public static extern int ShowCursor(bool bShow);

    public static void Show() => ShowCursor(true);

    public static void Hide() => ShowCursor(false);
}