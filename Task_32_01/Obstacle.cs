using System;
using System.Collections.Generic;
public abstract class Obstacle
{
    public string Name { get; }
    protected Obstacle(string name)
    {
        Name = name;
    }
    public abstract void Affect(Kolobok kolobok);
}
