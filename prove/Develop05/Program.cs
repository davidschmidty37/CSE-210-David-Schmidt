using System;
using System.Collections.Generic;

class Program
{
    private List<ActiveGoal> goals = new List<ActiveGoal>();
    private int totalScore = 0;
    private Menu menu = new Menu();

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    public void Run()
    {
        int choice;

        do
        {
            choice = menu.DisplayMenu();

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    RecordGoalProgress();
                    break;
                case 3:
                    ShowGoals();
                    break;
                case 4:
                    ShowTotalScore();
                    break;
                case 5:
                    Console.WriteLine("Thanks for using the Goal Helper 3000!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please restart and try again.");
                    break;
            }
        } while (choice != 5);
    }

    private void CreateGoal()
    {
        int goalType = menu.ChooseGoalType();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine() ?? "Unnamed Goal";

        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine() ?? "No description";

        switch (goalType)
        {
            case 1: 
                goals.Add(new SimpleGoal(name, description));
                Console.WriteLine($"Simple Goal '{name}' created!");
                break;

            case 2: 
                goals.Add(new EternalGoal(name, description));
                Console.WriteLine($"Eternal Goal '{name}' created!");
                break;

            case 3: 
                Console.Write("Define the required number of times to complete: ");
                int requiredTimes = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("How many bonus points will be awarded for completion: ");
                int bonusPoints = int.Parse(Console.ReadLine() ?? "0");

                goals.Add(new ChecklistGoal(name, description, requiredTimes, bonusPoints));
                Console.WriteLine($"Checklist Goal '{name}' created!");
                break;

            default:
                Console.WriteLine("Invalid goal type. Returning to main menu.");
                break;
        }
    }

    private void RecordGoalProgress()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available. Please create a goal first.");
            return;
        }

        Console.WriteLine("\nSelect a goal to record progress:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].DisplayGoal();
        }
        
        Console.Write("Enter the goal number: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex >= 1 && goalIndex <= goals.Count)
        {
            goalIndex--; // Adjust for 0-based indexing
            goals[goalIndex].RecordProgress();
            totalScore += goals[goalIndex].Points;
        }
        else
        {
            Console.WriteLine("Invalid goal number. Please try again.");
        }
    }

    private void ShowGoals()
    {
        Console.WriteLine("\n Goals ");
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        foreach (var goal in goals)
        {
            goal.DisplayGoal();
        }
    }

    private void ShowTotalScore()
    {
        Console.WriteLine($"\nYour current score is: {totalScore}");
    }
}
