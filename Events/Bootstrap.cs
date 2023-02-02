using Entitas;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab;

    private Systems _systems;
    private GameEventSystems _gameEventSystems;

    private void Start()
    {
        Contexts contexts = Contexts.sharedInstance;
        _systems = new Systems()
            .Add(new CreatePrefabSystem(_prefab, contexts))
            .Add(new HeightChangeSystem(contexts));

        var entity = contexts.game.CreateEntity();
        entity.AddHeight(0);

        _gameEventSystems = new GameEventSystems(contexts);
        _gameEventSystems.Initialize();
        _systems.Initialize();
    }

    private void Update()
    {
        _gameEventSystems.Execute();
        _systems.Execute();
    }
}
