using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ModName.Core.Injectors;
using ModName.Interfaces;

namespace ModName.Core.Factories;

public class DrawableFactory
{
    private readonly Dictionary<string, Type> _drawableTypes;

    public DrawableFactory()
    {
        _drawableTypes = Assembly.GetAssembly(typeof(IInjectDrawable))
            .GetTypes()
            .Where(t => typeof(IInjectDrawable).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .ToDictionary(t => t.Name, t => t);

        ModLogger.Log($"DrawableFactory initialized with {_drawableTypes.Count} drawable types.");
    }

    public void CreateAll()
    {
        ModLogger.Log("Starting creation of all drawable instances.");

        foreach (var type in _drawableTypes.Values)
        {
            try
            {
                var instance = (IInjectDrawable)Activator.CreateInstance(type);
                new DrawableSelfInjector(instance).Inject();
                ModLogger.Log($"Successfully created and injected drawable instance of type {type.Name}.");
            }
            catch (Exception ex)
            {
                ModLogger.LogError($"Failed to create or inject drawable instance of type {type.Name}: {ex.Message}");
            }
        }

        ModLogger.Log("Completed creation of all drawable instances.");
    }
}