﻿namespace Roxijn.Core;

public class Application
{
    public Application()
    {
        Engine = new Engine();
        Generator = new Generator();

        Engine.Generator = Generator;
    }

    public Engine Engine { get; private set; }
    public Generator Generator { get; private set; }

    /// <summary>
    /// Starts the application
    /// 
    /// Once started, Start will not return
    /// </summary>
    public void Start() => Engine.Loop();

    public void Stop() => Generator.Running = false;
}