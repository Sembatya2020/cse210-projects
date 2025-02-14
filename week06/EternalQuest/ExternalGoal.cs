using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void Complete()
    {
        // Eternal goals cannot be completed, so no changes should happen here
        Console.WriteLine($"Eternal Goal '{Name}' cannot be marked as completed.");
    }

    public override int GetPoints()
    {
        return Points;
    }
}
