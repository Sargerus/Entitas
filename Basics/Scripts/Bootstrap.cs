using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    private InputFeature _inputFeature;

    private void Start()
    {
        Contexts contexts = Contexts.sharedInstance;

        _inputFeature = new InputFeature(contexts);
        _inputFeature.Initialize();

        var e = contexts.game.CreateEntity();
        e.AddMove(Vector2.zero);
    }

    private void Update()
    {
        _inputFeature.Execute();
    }
}
