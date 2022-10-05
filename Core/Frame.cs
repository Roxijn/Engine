namespace Roxijn.Core;

public readonly struct Frame
{
    /// <summary>
    /// The amount of time since the engine started
    /// </summary>
    public readonly double elapsed;

    /// <summary>
    /// The amount of time in this frame
    /// </summary>
    public readonly float delta;

    public Frame()
    {
        Time.Cycle();
        delta = Time.Delta;
        elapsed = Time.Elapsed;
    }
}