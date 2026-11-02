using System;

partial class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        string? input = Console.ReadLine();
        if (!int.TryParse(input, out int gradePercentage))
        {
            Console.WriteLine("Please enter a valid whole number.");
            return;
        }

        string letterGrade;
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}");
        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed the class.");
        }
        else
        {
            Console.WriteLine("You did not pass the class.");
        }
    }
}