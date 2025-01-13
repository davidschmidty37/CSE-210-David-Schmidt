using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a series of numbers. Enter 0 when finished.");
        
        Console.Write("-> ");
        string userinput = Console.ReadLine();
        int num = int.Parse(userinput);

        List<int> numbers = new List<int>();
        numbers.Add(num);

        while (num != 0)
        {
            Console.Write("-> ");
            string input = Console.ReadLine();
            int numb = int.Parse(input);
            numbers.Add(numb);
            num = numb;
        } 

        int total = numbers.Sum();
        Console.WriteLine($"The sum of the numbers is {total}.");

        double average = numbers.Average();
        Console.WriteLine($"The average of the list is {average}.");

        int highest = numbers.Max();
        Console.WriteLine($"THe highest number is {highest},");
    }  
}