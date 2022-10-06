namespace Roxijn.Core.Base;

/// <summary>
/// This is the main loop.
/// It uses a generator to create frames on every cycle.
/// </summary>
/// <typeparam name="T">Frame descriptor</typeparam>
public class EngineBase<T> where T : new()
{
    protected GeneratorBase<T> generator = new GeneratorBase<T>();

    public event Action<T>? tick = null!;

    /// <summary>
    /// Starts the main loop.
    /// </summary>
    public void Start() => Loop();

    /// <summary>
    /// Stops the main loop.
    /// </summary>
    public void Stop() => generator.Running = false;
    
    protected void Loop()
    {
        if (tick == null) return;
        foreach (var frame in generator) tick(frame);
    }

}
