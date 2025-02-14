// Goal.cs
using System;

public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{Name}: {Description} (Points: {Points})");
    }

    public abstract void Complete();
    public abstract int GetPoints();
}
