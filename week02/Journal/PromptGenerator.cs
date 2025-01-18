using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>();

    public void InitializePrompts()
    {
        _prompts.Add("What made you smile today?");
        _prompts.Add("Describe a challenge you faced and overcame.");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("Write about a goal you want to achieve.");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}