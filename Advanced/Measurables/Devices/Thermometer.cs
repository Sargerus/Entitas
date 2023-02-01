public class Thermometer : IMeasureDevice
{
    public float Measure(IMeasurable measurable)
    {
        return measurable.Property1 * measurable.Property2 - measurable.Property3;
    }
}
