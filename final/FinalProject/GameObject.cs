using System;
using System.Collections.Generic;

// Base class for all game objects
abstract class GameObject
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    
    public GameObject(string name, string description)
    {
        Name = name;
        Description = description;
    }
}