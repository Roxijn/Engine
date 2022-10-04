using System.Collections;

namespace Roxijn.Core;

public class Generator : Generator<Frame> { }

public class Generator<T> : IEnumerable<T> where T : new()
{
    private Boolean running = false;

    /// <summary>
    /// True when the generator is generating new objects
    /// Can be set to false to stop the generator
    /// </summary>
    public Boolean Running { get => running; set => running &= value; }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<T> GetEnumerator()
    {
        Running = true;
        while (running) yield return new T();
    }
}