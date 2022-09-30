namespace Roxijn.Core;

public class Engine : Engine<Frame> {}

public class Engine<T>
{
    public IEnumerable<T>? Generator;
    public event EventHandler<T>? Tick;

    public void Loop ()
    {
        if (Generator == null) return;
        foreach(var frame in Generator) Tick?.Invoke(this, frame);
    }
}
