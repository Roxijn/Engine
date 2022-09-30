using System.Collections;

namespace Roxijn.Core;

public class Generator : Generator<Frame> { }

public class Generator<T> : IEnumerable<T> where T : new()
{
    public Boolean Running { get; set; } = false;

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<T> GetEnumerator()
    {
        Running = true;
        while (Running) yield return new T();
    }
}