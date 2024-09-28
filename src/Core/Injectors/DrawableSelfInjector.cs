using System;
using System.Collections.Generic;
using System.Reflection;
using DuckGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ModName.Core.ModSetup;
using ModName.Interfaces;

namespace ModName.Core.Injectors;

#pragma warning disable CS0067
public class DrawableSelfInjector(IInjectDrawable drawable) : IDrawable
{
    public void Inject() 
        => (typeof(Game).GetField("drawableComponents", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic)?.GetValue(MonoMain.instance) as List<IDrawable>)?.Add(this);
    
    public void Draw(GameTime gameTime)
    {
        
        Graphics.screen.Begin(SpriteSortMode.BackToFront, BlendState.NonPremultiplied, SamplerState.PointClamp, DepthStencilState.Default, RasterizerState.CullNone, null, Microsoft.Xna.Framework.Matrix.Identity);
        ModGlobal.GuiRenderer.BeginLayout(gameTime);
        drawable.Draw();
        ModGlobal.GuiRenderer.EndLayout();
        Graphics.screen.End();
    }

    public bool Visible => true;
    public int DrawOrder => 1;
    public event EventHandler<EventArgs> VisibleChanged;
    public event EventHandler<EventArgs> DrawOrderChanged;
}