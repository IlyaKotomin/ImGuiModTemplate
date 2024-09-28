using System;
using System.Collections.Generic;
using System.Reflection;
using DuckGame;
using Microsoft.Xna.Framework;
using ModName.Interfaces;

namespace ModName.Core.Injectors;

#pragma warning disable CS0067
public class UpdateableSelfInjector(IInjectUpdateable updateable) : IUpdateable
{
    public void Inject() 
        => (typeof(Game).GetField("updateableComponents", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(MonoMain.instance) as List<IUpdateable>)?.Add(this);
    
    public void Update(GameTime gameTime) => updateable.Update();

    public bool Enabled => true;
    public int UpdateOrder => 1;
    public event EventHandler<EventArgs> EnabledChanged;
    public event EventHandler<EventArgs> UpdateOrderChanged;
}