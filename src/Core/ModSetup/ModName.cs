//Kotoxik`s mod template

using DuckGame;

namespace ModName.Core.ModSetup;

public class ModName : DisabledMod
{
    public ModName() => ModInitialize = new ModInitialize(this);
    private ModInitialize ModInitialize { get; }
        
    protected override void OnPreInitialize()
    {
        base.OnPreInitialize();
            
        ModInitialize.PreInitialize();
    }

    protected override void OnPostInitialize()
    {
        ModInitialize.PostInitialize();

        base.OnPostInitialize();
    }
    
}