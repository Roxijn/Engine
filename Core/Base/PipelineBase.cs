using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roxijn.Core.Base;

public abstract class PipelineBase<T> where T : new()
{
    public abstract void Step(T frame);

    public virtual void Attach(EngineBase<T> engine) => engine.tick += Step;
    public virtual void Remove(EngineBase<T> engine) => engine.tick -= Step;

    public static EngineBase<T> operator +(EngineBase<T> engine, PipelineBase<T> pipeline) 
    {
        pipeline.Attach(engine);
        return engine;
    }
}
