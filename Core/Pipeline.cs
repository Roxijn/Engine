namespace Roxijn.Core;

public abstract class Pipeline : Base.Pipeline<Frame> {
    public virtual void Attach(Application app)
    {
        app.engine.tick += Step;
    }
}
