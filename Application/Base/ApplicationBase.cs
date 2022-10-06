using static Glfw;

namespace Roxijn.Application.Base;

public abstract class ApplicationBase : IDisposable
{
    public ApplicationBase()
    {
        if (glfwInit() == GLFW_FALSE) throw new Exception("Glfw failed init");
    }

    public void Dispose()
    {
        glfwTerminate();
    }
}
