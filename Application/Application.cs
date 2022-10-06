using Roxijn.Core;
using Roxijn.Input;
using Roxijn.Rendering;

namespace Roxijn.Application;

public class Application : Base.ApplicationBase
{
    public Application()
    {
        engine = new Engine();

        engine += new InputPipeline();
        engine += new RenderingPipeline();
    }

    public Engine engine;

    /// <summary>
    /// Launches the application, consuming the main thread.
    /// </summary>
    public void Launch() => engine.Start();
}