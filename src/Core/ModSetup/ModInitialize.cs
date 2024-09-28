using DuckGame;
using ImGuiNET;
using ModName.Core.Factories;
using ModName.Core.ImGuiAdapter;
using ModName.Core.ModSetup.AssemblyLoading;
using ModName.LogSystem.Loggers;

namespace ModName.Core.ModSetup;

internal class ModInitialize(Mod mod)
{
    public static void PreInitialize() {}

    public void PostInitialize()
    {
        InitializeLogging();
        LoadSharedAssemblies();
        InitializeImGui();
        CreateFactories();
    }

    private void InitializeLogging()
    {
        ModLogger.Loggers.Add(new DevConsoleLogger("ModName"));
    }

    private void LoadSharedAssemblies()
    {
        var sharedDllsPath = mod.GetPath("SharedDlls");
        var assemblyLoader = new AssemblyLoader(sharedDllsPath);
        assemblyLoader.LoadAssemblies();
    }

    private void InitializeImGui()
    {
        var imGuiContext = ImGui.CreateContext();
        ImGui.SetCurrentContext(imGuiContext);
        ModLogger.Log($"ImgUI context: {imGuiContext}");

        ModGlobal.GuiRenderer = new ImGuiRenderer(MonoMain.instance);
        ModGlobal.GuiRenderer.RebuildFontAtlas();
        ModLogger.Loggers.Add(new ImGuiLogger());
    }

    private void CreateFactories()
    {
        new UpdateableFactory().CreateAll();
        new DrawableFactory().CreateAll();
    }
}