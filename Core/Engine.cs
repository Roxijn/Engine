namespace Roxijn.Core;

public class Engine : Engine<Frame> {}

public class Engine<T>
{
    public IEnumerable<T>? Generator;
    public event EventHandler<T> Tick { add => tick += value; remove => tick -= value; }

    private event EventHandler<T>? tick;

    public void Loop ()
    {
        if (Generator == null) return;
        foreach(var frame in Generator) tick?.Invoke(this, frame);
    }
}
