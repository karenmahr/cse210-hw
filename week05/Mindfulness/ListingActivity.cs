//ATTRIBUTES
//_count:int
//_prompts:List<string>

//METHODS
//Run():void
//GetRandomPrompt():void
//GetListFromUser():List<string>
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity (string name, string description, int duration, int count)
      :base (name, description, duration)
    {
        _count = count;
        _prompts = new List<string>();   
        name = "Listing Activity"; 
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area"; 
    }

    private void Run()
    {
        Console.WriteLine (ShowSpinner());       
        Console.WriteLine ("List as many responses you can to the following prompt");
        Console.WriteLine ($"You may begin in {ShowCountDown}");
    }
    public void InitializeRandomPropmt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }    

    public List <string> GetListFromUser()
    {
    return List <string>;
    }

    Console.WriteLine(_prompts.Count);
    Console.WriteLine "You listed {} items"
}