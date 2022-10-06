namespace Roxijn.Core.Base;

/// <summary>
/// This is the main loop.
/// It uses a generator to create frames on every cycle.
/// </summary>
/// <typeparam name="T">Frame descriptor</typeparam>
public class Engine<T> where T : new()
{
    public IEnumerable<T>? generator;

    public event Action<T>? start;
    public event Action<T>? tick;
    public event Action<T>? stop;

    public void Loop()
    {
        generator ??= new Generator<T>();

        start?.Invoke(new T());
        foreach (var frame in generator) tick?.Invoke(frame);
        stop?.Invoke(new T());
    }
}
