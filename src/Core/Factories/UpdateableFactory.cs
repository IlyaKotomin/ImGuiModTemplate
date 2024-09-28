using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ModName.Core.Injectors;
using ModName.Interfaces;

namespace ModName.Core.Factories;

public class UpdateableFactory
{
    private readonly Dictionary<string, Type> _updateableTypes;

    public UpdateableFactory()
    {
        _updateableTypes = Assembly.GetAssembly(typeof(IInjectUpdateable))
            .GetTypes()
            .Where(t => typeof(IInjectUpdateable).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .ToDictionary(t => t.Name, t => t);

        ModLogger.Log($"UpdateableFactory initialized with {_updateableTypes.Count} updateable types.");
    }

    public void CreateAll()
    {
        ModLogger.Log("Starting creation of all updateable instances.");

        foreach (var type in _updateableTypes.Values)
        {
            try
            {
                var instance = (IInjectUpdateable)Activator.CreateInstance(type);
                new UpdateableSelfInjector(instance).Inject();
                ModLogger.Log($"Successfully created and injected updateable instance of type {type.Name}.");
            }
            catch (Exception ex)
            {
                ModLogger.LogError($"Failed to create or inject updateable instance of type {type.Name}: {ex.Message}");
            }
        }

        ModLogger.Log("Completed creation of all updateable instances.");
    }
}