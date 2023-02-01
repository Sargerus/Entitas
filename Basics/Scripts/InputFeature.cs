public class InputFeature : Feature
{
    private IPositionService _positionService;

    public InputFeature(Contexts contexts)
        : base("Input Feature")
    {
        _positionService = new UnityPositionService();

        Add(new MoveSystem(contexts, _positionService));
    }
}
