//ATTRIBUTES:
//_name string
//_description:string
//_duration:int

//METHODS
//DisplayStartingMessage():void
//DisplayEndingMessage():void
//ShowSpinner(seconds:int):void
//ShowCountDown(seconds:int):void
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity (string name, string description)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    private void DisplayStartingMessage()
    {
        Console.WriteLine "Menu Options:"

        Console.WriteLine "1. Start breathing activity"  
        Console.WriteLine "2. Start reflecting activity"  
        Console.WriteLine "3. Start listing activity"  
        Console.WriteLine "4. Quit"                        

        Console.WriteLine "Select a choice from the menu: "  
    }
    private string GetName()
    {
        return _name;
    }    
    private string GetDescription()
    {
        return _description;
    }
    private int GetDuration()
    {
        Console.WriteLine "How long, in seconds, would you like for your session?"
        return _duration;
    }
    private void DisplayEndingMessage()
    {
        Console.Write "Well done!!" 
        Console.Write $"You have completed another {duration} seconds of the Breathing Activity";
    }
    private void ShowSpinner()
     List <string> animationStrings = new List<string>();
     animationStrings.Add("|");
     animationStrings.Add("/");
     animationStrings.Add("-");
     animationStrings.Add("\\");
     animationStrings.Add("|");
     animationStrings.Add("/");
     animationStrings.Add("-");
     animationStrings.Add("\\");

    foreach (string s in animationStrings)
    {
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }

    private void ShowCountDown()
    List <int> countDown = new List<int>();
    countDown.Add("3");
    countDown.Add("2");
    countDown.Add("1");

    foreach (int c in countDown)
    {
        Console.Write(c);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    } 

    //DateTime startTime = DateTime.Now;
    //DateTime endTime = startTime.AddSeconds(10);

    //while (DateTime.Now<endTime)
    //{
    //   Console.Write(".");
    //    Thread.Sleep(1000);
    //}
    

}