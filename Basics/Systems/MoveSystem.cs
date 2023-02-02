using Entitas;
using System.Collections.Generic;

public class MoveSystem : ReactiveSystem<GameEntity>
{
    private Contexts _contexts;
    private IPositionService _positionService;

    public MoveSystem(Contexts contexts, IPositionService positionService)
        : base(contexts.game)
    {
        _contexts = contexts;
        _positionService = positionService;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return _contexts.game.CreateCollector(GameMatcher.Move);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasMove;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var entity in entities)
        {
            entity.ReplaceMove(_positionService.Position);
        }
    }
}
