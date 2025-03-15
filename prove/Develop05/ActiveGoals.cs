using System;
using System.Collections.Generic;


public abstract class ActiveGoal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; protected set; }
    public bool IsCompleted { get; protected set; }

    public ActiveGoal(string name, string description)
    {
        Name = name;
        Description = description;
        Points = 0;
        IsCompleted = false;
    }

    
    public abstract void RecordProgress();

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{Name} - {Description}. Points: {Points}");
    }
}

