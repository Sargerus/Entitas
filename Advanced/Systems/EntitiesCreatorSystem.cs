using Entitas;

public class EntitiesCreatorSystem : IInitializeSystem
{
    private Contexts _contexts;

    public EntitiesCreatorSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Initialize()
    {
        var uniqueTemperatureHolder = _contexts.atmosphere.CreateEntity();
        uniqueTemperatureHolder.AddTemperatureHolder(0);
    }
}