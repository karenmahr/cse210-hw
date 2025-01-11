using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
    }
     Consol.Write ("What is your grade percentage? ")
        string answer = Console.ReadLine();
        int GradePercentage = int.Parse(answer);

        string letter = "";

        if (GradePercentage >= 90)
        {
            letter = "A";
        }
        else if (GradePercentage >= 80 && GradePercentage <90)
        {
            letter = "B";
        }
        else if (GradePercentage >= 70 && GradePercentage <80)
        {
            letter = "C";
        }
        else if (GradePercentage >= 60 && GradePercentage <70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}")

        if (GradePercentage >=70)
        {
            Console.WriteLine("Congratulations, you approved the course!")
        }
        else
        {
            Console.WriteLine("Better luck next time")
        }
}