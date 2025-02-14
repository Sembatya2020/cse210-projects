// SimpleGoal.cs
using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override void Complete()
    {
        Console.WriteLine($"Goal Completed: {Name}");
    }

    public override int GetPoints()
    {
        return Points;
    }
}
