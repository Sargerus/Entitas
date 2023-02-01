public class UnityConsoleLogger : ILogger
{
    public void Log(string message)
    {
        UnityEngine.Debug.Log(message);
    }
}
