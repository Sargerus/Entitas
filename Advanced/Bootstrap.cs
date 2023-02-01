using Entitas;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    private Systems _systems;
    private ILogger _logger;

    private IMeasureDevice _device;
    private IMeasurable _subject;

    private void Awake()
    {
        _logger = new UnityConsoleLogger();
        _device = new Thermometer();
        _subject = new Sun();
    }

    private void Start()
    {
        Contexts contexts = Contexts.sharedInstance;
        _systems = new Systems()
            .Add(new EntitiesCreatorSystem(contexts))
            .Add(new TemperatureLoggerSystem(contexts, _logger))
            .Add(new TemeperatureMeasurementSystem(contexts, _device, _subject));

        _systems.Initialize();
    }

    private void Update()
    {
        _systems.Execute();
    }
}