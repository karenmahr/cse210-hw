using System;

class Program
{
    static void Main(string[] args) //Exercise 1
    {
        Consol.Write ("what is your first name?")
        string FirstName = Console.ReadLine();

        Consol.Write ("What is your last name?")
        string LastName = Console.ReadLine();

        Console.WriteLine ($"Your name is {LastName}, {FirstName} {LastName}.");

        //Exercise 2
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

        //Exercise 3
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != MagicNumber)
        {
            Consol.Write ("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (Guess< MagicNumber)
            {
                Console.WriteLine("Higher")
            }

            else if (Guess> MagicNumber)
            {
                Console.WriteLine("Lower")
            }
            else(Guess == MagicNumber)
            {
                Console.WriteLine("You guessed it!")
            }
        }
        //Exercise 4
            List <int> Number = new List <int> ();
            int userNumber =-1;   
            while (NumberEnter != 0)
            {

            NumberEnter = Console.WriteLine("Enter number: ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            } 

                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }

                Console.WriteLine($"The sum is: {sum}.");

                float average = ((float)sum) / numbers.Count;
                Console.WriteLine($"The average is: {average}.");

                int max = numbers[0]
                  foreach (int number in numbers)
                {
                    if (number > max)
                    {
                        // if this number is greater than the max, we have found the new max!
                        max = number;
                    }
                }
                Console.WriteLine($"The largest number is: {max}.");

        }
    }  
}