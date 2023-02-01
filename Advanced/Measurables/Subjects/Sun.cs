public class Sun : IMeasurable
{
    private System.Random _random;

    public Sun()
    {
        _random = new System.Random(System.Guid.NewGuid().GetHashCode());
    }

    public float Property1 { get => (float)_random.NextDouble(); }
    public float Property2 { get => (float)_random.NextDouble(); }
    public float Property3 { get => (float)_random.NextDouble(); }
}
