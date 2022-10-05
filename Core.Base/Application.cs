using static Glfw;

namespace Roxijn.Core.Base;

public class Application : IDisposable
{
    public Application()
    {
        if (glfwInit() == GLFW_FALSE) throw new Exception("Glfw failed init");
    }

    public void Dispose()
    {
        glfwTerminate();
    }
}
