using Entitas;
using Entitas.CodeGeneration.Attributes;

[Event(EventTarget.Self)]
public class HeightComponent : IComponent
{
    public float Height;
}
