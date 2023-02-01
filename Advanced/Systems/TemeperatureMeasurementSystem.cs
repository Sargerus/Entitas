using Entitas;

public class TemeperatureMeasurementSystem : IExecuteSystem
{
    private IMeasureDevice _thermoteter;
    private IMeasurable _subject;
    private Contexts _contexts;

    public TemeperatureMeasurementSystem(Contexts contexts, IMeasureDevice device, IMeasurable subject)
    {
        _thermoteter = device;
        _subject = subject;
        _contexts = contexts;
    }

    public void Execute()
    {
        _contexts.atmosphere.temperatureHolder.Temperature = _thermoteter.Measure(_subject);
    }
}
