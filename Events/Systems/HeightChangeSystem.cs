using Entitas;
using System;

public class HeightChangeSystem : IExecuteSystem
{
    private Contexts _contexts;
    private IGroup<GameEntity> _group;
    private Random _rand;

    public HeightChangeSystem(Contexts contexts)
    {
        _contexts = contexts;
        _group = _contexts.game.GetGroup(GameMatcher.Height);
        _rand = new Random(DateTime.Now.Millisecond);
    }

    public void Execute()
    {
        foreach (var entity in _group)
        {
            entity.ReplaceHeight((float)_rand.NextDouble());
        }
    }
}
