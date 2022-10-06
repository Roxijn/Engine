using static Glfw;

namespace Roxijn.Core.Base;

public abstract class Application : IDisposable
{
    public Application()
    {
        if (glfwInit() == GLFW_FALSE) throw new Exception("Glfw failed init");
    }

    private GLFWwindow window;

    public void Dispose()
    {
        glfwTerminate();
    }

    public abstract void Start();

    public abstract void Stop();
}
