namespace Roxijn.Core;

public class Application : Base.Application
{
    public Application()
    {
        engine = new Engine();
        generator = new Generator();
        engine.generator = generator;
    }

    public Engine engine;
    public Generator generator;

    /// <summary>
    /// Starts the application
    /// Once started, Start will not return
    /// </summary>
    public void Start() => engine.Loop();

    /// <summary>
    /// Stops the application
    /// </summary>
    public void Stop() => generator.Running = false;
}