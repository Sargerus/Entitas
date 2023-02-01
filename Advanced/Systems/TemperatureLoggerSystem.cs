using Entitas;
using System.Collections.Generic;

public class TemperatureLoggerSystem : ReactiveSystem<AtmosphereEntity>
{
    private Contexts _contexts;
    private ILogger _logger;

    public TemperatureLoggerSystem(Contexts contexts, ILogger logger) : base(contexts.atmosphere)
    {
        _contexts = contexts;
        _logger = logger;
    }

    protected override ICollector<AtmosphereEntity> GetTrigger(IContext<AtmosphereEntity> context)
    {
        return context.CreateCollector<AtmosphereEntity>(AtmosphereMatcher.TemperatureHolder.Added());
    }

    protected override bool Filter(AtmosphereEntity entity)
    {
        return entity == _contexts.atmosphere.temperatureHolderEntity;
    }

    protected override void Execute(List<AtmosphereEntity> entities)
    {
        foreach (var entity in entities)
        {
            _logger.Log(entity.temperatureHolder.Temperature.ToString());
        }
    }
}
