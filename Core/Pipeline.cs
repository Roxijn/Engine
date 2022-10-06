using Roxijn.Core.Base;

namespace Roxijn.Core;

public abstract class Pipeline : Base.PipelineBase<Frame>
{
    public virtual void Attach(Engine engine) => base.Attach(engine);
    public virtual void Remove(Engine engine) => base.Remove(engine);

    public static Engine operator +(Engine engine, Pipeline pipeline)
    {
        pipeline.Attach(engine);
        return engine;
    }

    public static Engine operator -(Engine engine, Pipeline pipeline)
    {
        pipeline.Remove(engine);
        return engine;
    }
}
