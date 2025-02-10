//METHOD
//Run():void
using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) 
      :base (name, description, duration)
    {
        name = "Breathing Activity";
        description ="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    private void Run()
    { 
        Console.WriteLine ("How long, in seconds, would you like for your session?");
        Console.WriteLine ("Get ready...");  
        Console.WriteLine ($"{ShowSpinner()}"); 
        Console.WriteLine ($"Breathe in...{ShowCountDown()}");       
        Console.WriteLine ($"Breathe out...{ShowCountDown()}");          
    }
}
