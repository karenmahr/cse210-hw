using System;

class Program
{
    static void Main(string[] args)
    {
        string _reference= "John 3:16";
        string _words = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        string _userInput ="";

        Console.WriteLine ($"{_reference} {_words}");
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

        _userInput = Console.ReadLine();

        if (string.IsNullOrEmpty(_userInput))
        {
            Console.Clear();
            Console.WriteLine("{reference} {GetDisplayText}");
        }
        
        else
        {
            Environment.Exit(0);
        }
    }

}