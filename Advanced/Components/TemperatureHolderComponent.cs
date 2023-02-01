using Entitas;
using Entitas.CodeGeneration.Attributes;

[Atmosphere, Unique]
public class TemperatureHolderComponent : IComponent
{
    public float Temperature;
}
