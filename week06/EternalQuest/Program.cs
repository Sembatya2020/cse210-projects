using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        // Create goals
        goals.Add(new SimpleGoal("Run a Marathon", "Complete a marathon", 1000));
        goals.Add(new EternalGoal("Scripture Study", "Study scriptures daily", 100));
        goals.Add(new ChecklistGoal("Attend the Temple", "Attend the temple 10 times", 50, 10, 200)); // Added ChecklistGoal example

        // Simulate user completing goals
        foreach (Goal goal in goals)
        {
            goal.DisplayGoal();  // Display the goal
            goal.Complete();  // Complete the goal
            Console.WriteLine();  // Adds space between goals for readability
        }

        // Calculate total points and achievements
        int totalPoints = goals.Sum(g => g.GetPoints());
        Console.WriteLine($"Total Points: {totalPoints}");

        // Unlock achievements based on total points
        if (totalPoints >= 3000)
        {
            Console.WriteLine("Level Up! You've unlocked a new achievement!");
        }
        if (totalPoints >= 5000)
        {
            Console.WriteLine("Amazing! You’ve unlocked the 'Goal Master' achievement!");
        }
        if (totalPoints >= 10000)
        {
            Console.WriteLine("Incredible! You've unlocked the 'Super Achiever' badge!");
        }

        // Difficulty Levels for Goals (based on user-selected levels)
        Console.WriteLine("\nDifficulty Levels Impact:");
        foreach (var goal in goals.OfType<ChecklistGoal>())
        {
            string difficulty = goal.GetPoints() > 100 ? "Hard" : "Medium";  // If points > 100, consider it Hard
            int difficultyMultiplier = difficulty == "Hard" ? 2 : 1;  // Adjust multiplier based on difficulty
            int adjustedPoints = goal.GetPoints() * difficultyMultiplier;  // Apply difficulty multiplier
            Console.WriteLine($"Checklist Goal '{goal.Name}' has been set to {difficulty} with {adjustedPoints} points.");
        }
    }
}
