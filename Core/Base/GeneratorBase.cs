using System.Collections;

namespace Roxijn.Core.Base;

/// <summary>
/// Enumerates forever until Running is set to false.
/// Each yield creates a new T.
/// This is used to generate a frame structure to be
/// passed into the scene structure in the main loop.
/// </summary>
/// <typeparam name="T">The type to generate</typeparam>
public class GeneratorBase<T> : IEnumerable<T> where T : new()
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
        running = true;
        while (running) yield return new T();
    }
}