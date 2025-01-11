using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
    }
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
}