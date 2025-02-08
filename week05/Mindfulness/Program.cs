using System;
//Menu with 4 options(breathing, reflecting, listing or quit)
class Program : Activity
{
    static void Main(string[] args)
    {  
        if DisplayStartingMessage = 1
        {
            Console.WriteLine(BreathingActivity.Run());   
            Console.WriteLine (DisplayEndingMessage());     
            Console.WriteLine {ShowSpinner()}                    
        }
        else if DisplayStartingMessage = 2
        {
            Console.WriteLine(ReflectingActivity.Run());
            Console.WriteLine(GetRandomPromptReflecting);
            Console.WriteLine $"Now ponder on each of the following questions as they relate to this experience. Yo may begin in {}"
            Console.WriteLine (GetRandomQuestion());
            Console.WriteLine (DisplayEndingMessage());
            Console.WriteLine {ShowSpinner()}            
        }
        else if DisplayStartingMessage = 3
        {
            Console.WriteLine(ListingActivity.Run());
            Console.WriteLine(GetRandomPrompt);
            Console.WriteLine $"You listed {} items!"
            Console.WriteLine (DisplayEndingMessage());    
            Console.WriteLine {ShowSpinner()}        
        }
        else
        {
            Console.WriteLine "Thank you"
        }
    }
}