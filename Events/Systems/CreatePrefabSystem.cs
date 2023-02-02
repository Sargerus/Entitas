using Entitas;
using UnityEngine;

public class CreatePrefabSystem : IInitializeSystem
{
    private GameObject _prefab;
    private Contexts _contexts;

    public CreatePrefabSystem(GameObject prefab, Contexts contexts)
    {
        _prefab = prefab;
        _contexts = contexts;
    }

    public void Initialize()
    {
        IGroup<GameEntity> entities = _contexts.game.GetGroup(GameMatcher.Height);

        foreach (GameEntity entity in entities)
        {
            var newObj = GameObject.Instantiate(_prefab);
            IEventListener[] listeners = newObj.GetComponents<IEventListener>();

            foreach (IEventListener listener in listeners)
            {
                listener.RegisterListeners(entity);
            }
        }
    }
}

