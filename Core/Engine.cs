namespace Roxijn.Core;

public class Engine : Base.EngineBase<Frame>
{
    public Engine()
    {
        generator = new Generator();
    }
}
