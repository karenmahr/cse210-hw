//METHOD
//Run():void
public class BreathingActivity : Activity
{
    private void Run()
    {
        Console.WriteLine "Welcome to the Breathing Activity."
        Console.WriteLine "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        Console.WriteLine "How long, in seconds, would you like for your session?"
        Console.WriteLine "Get ready..."  
        Console.WriteLine {ShowSpinner()}      
        Console.WriteLine "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
        Console.WriteLine $"Breathe in...{ShowCountDown()}"       
        Console.WriteLine $"Breathe out...{ShowCountDown()}"          
    }
}
