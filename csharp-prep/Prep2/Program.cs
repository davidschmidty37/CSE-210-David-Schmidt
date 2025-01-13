using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percent? ");
        string userinput = Console.ReadLine();
        int grade = int.Parse(userinput);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        
        Console.WriteLine($"You received a {letter} in your class");

        
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratulations on passing your class!");
        }
        else
        {
            Console.WriteLine("You didn't pass, good luck next time!");
        }
          
    }
}