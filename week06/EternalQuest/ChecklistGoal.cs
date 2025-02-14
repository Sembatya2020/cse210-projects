using System;

public class ChecklistGoal : Goal
{
    public int Target { get; set; }
    public int Progress { get; set; }
    public int BonusPoints { get; set; }

    // Constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonusPoints) : base(name, description, points)
    {
        Target = target;
        Progress = 0;
        BonusPoints = bonusPoints;
    }

    // This method will be used to mark progress for a checklist goal.
    public void RecordProgress()
    {
        if (Progress < Target)
        {
            Progress++;
            Console.WriteLine($"Progress for '{Name}': {Progress}/{Target}");
        }
        else
        {
            Console.WriteLine($"'{Name}' is already complete.");
        }
    }

    // This method will display the goal, including progress and bonus points if finished.
    public override void DisplayGoal()
    {
        string progressText = Progress < Target ? $"Progress: {Progress}/{Target}" : "Goal Completed!";
        string bonusText = Progress >= Target ? $"Bonus: {BonusPoints} points!" : "";
        Console.WriteLine($"{Name}: {Description} (Points: {Points})");
        Console.WriteLine($"{progressText} {bonusText}");
    }

    // Calculate total points, considering the bonus when completed
    public override int GetPoints()
    {
        if (Progress >= Target)
        {
            return Points + BonusPoints;
        }
        return Points;
    }

    public override void Complete()
    {
        // No additional logic needed, as progress is recorded separately
        Console.WriteLine($"Checklist Goal '{Name}' is being tracked with progress.");
    }
}
