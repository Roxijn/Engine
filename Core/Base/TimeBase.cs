using static Glfw;

namespace Roxijn.Core.Base;

/// <summary>
/// Abstracts away glfw timer,
/// </summary>
public abstract class TimeBase
{
    /// <summary>
    /// The number of ticks per second.
    /// </summary>
    protected static readonly ulong Frequency = glfwGetTimerFrequency();

    /// <summary>
    /// The elapsed time in seconds.
    /// </summary>
    protected static double Elapsed { get => glfwGetTime(); set => glfwSetTime(value); }

    /// <summary>
    /// The current tick count.
    /// </summary>
    protected static ulong Ticks { get => glfwGetTimerValue(); }
}