namespace Roxijn.Core;

/// <summary>
/// Keeps track of time.
/// The first values for Delta and Elapsed are always 0.
/// After that their values are relative to whenever Cycle() is called
/// </summary>
public abstract class Time : Base.TimeBase
{
    static Time()
    {
        Epoch = Ticks;
    }

    /// <summary>
    /// The ticks the engine started at.
    /// </summary>
    internal static readonly ulong Epoch;

    /// <summary>
    /// Updates previous and current values in frame.
    /// </summary>
    internal static void Cycle() => frame = frame.current != 0 ? (frame.current, Ticks) : (Epoch, Epoch);

    /// <summary>
    /// Keeps track of calls to Cycle.
    /// </summary>
    static (ulong previous, ulong current) frame;

    /// <summary>
    /// The time in seconds between frames.
    /// </summary>
    public static float Delta {
        get => (frame.current - frame.previous) * 1f / Time.Frequency;
    }

    /// <summary>
    /// The time in seconds since the first frame.
    /// </summary>
    public static new double Elapsed {
        get => (frame.current - Time.Epoch) * 1.0 / Time.Frequency;
    }
}
