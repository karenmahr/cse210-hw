//ATTRIBUTES
//_prompts:List<string>
//_questions:List<string>

//METHODS
//Run():void
//GetRandomPrompt():string
//GetRandomQuestion():string
//DisplayPrompt():void
//DisplayQuestions():void

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration) :base (name, description, duration)
    {
        _prompts = new List<string>();
        _questions = new List<string>();
        name = "Reflecting Activity";
        description ="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";     
    }

    private void Run()
    {
        Console.WriteLine ("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");     
        Console.WriteLine ("How long, in seconds, would you like for your session?"); 
        Console.WriteLine ("Get ready...");
        Console.WriteLine (ShowSpinner());           
        Console.WriteLine ("Consider the following prompt: ");   
    }
    public void InitializeRandomPropmtReflecting()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }
    public string GetRandomPromptReflecting()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }    
    private void DisplayPrompt()
    {
        Console.WriteLine (GetRandomPromptReflecting());
    }   

    public void InitializeRandomQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }    
    private void DisplayQuestions()
    {
        Console.WriteLine (GetRandomQuestion());
    }        
}     
