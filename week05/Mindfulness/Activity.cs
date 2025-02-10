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

    public Activity (string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    private void DisplayStartingMessage()
    {
        Console.WriteLine ($"Welcome to the {_name}.");
        Console.WriteLine ($"{_description}");
        Console.WriteLine ("How long, in seconds, would you like for your session?");
        Console.WriteLine  ("Get ready...");
        //Console.WriteLine ($"{ShowSpinner()}");         
    }
    public void GetDisplayStartingMessage()
    {
        Console.WriteLine ($"{DisplayStartingMessage}");
    }
    public string GetName()
    {
        return _name;
    }    
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    private void DisplayEndingMessage()
    {
        Console.Write ("Well done!!"); 
        Console.Write ($"You have completed another {_duration} seconds of the {_name}");
    }

    public void GetDisplayEndingMessage()
    {
        Console.WriteLine ($"{DisplayEndingMessage}");
    }
    public void ShowSpinner()
    {
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
    }
    private void ShowCountDown()
    {
    List <int> countDown = new List<int>();
    countDown.Add(3);
    countDown.Add(2);
    countDown.Add(1);

    foreach (int c in countDown)
    {
        Console.Write(c);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    } 
    }

    //DateTime startTime = DateTime.Now;
    //DateTime endTime = startTime.AddSeconds(10);

    //while (DateTime.Now<endTime)
    //{
    //   Console.Write(".");
    //    Thread.Sleep(1000);
    //}
    

}