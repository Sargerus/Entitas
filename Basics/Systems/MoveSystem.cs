using Entitas;

public class MoveSystem : IExecuteSystem, IInitializeSystem
{
    private IGroup<GameEntity> _group;
    private Contexts _contexts;
    private IPositionService _positionService;

    public MoveSystem(Contexts contexts, IPositionService positionService)
    {
        _contexts = contexts;
        _positionService = positionService;
    }

    public void Initialize()
    {
        _group = _contexts.game.GetGroup(GameMatcher.Move);
    }

    public void Execute()
    {
        foreach (var entity in _group)
        {
            entity.ReplaceMove(_positionService.Position);
        }
    }
}
