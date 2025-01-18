using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.InitializePrompts();

        Console.WriteLine("Welcome to the Journal Program!");
        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

                if (choice =="1")
                {
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your entry: ");
                    string entryText = Console.ReadLine();
                    journal.AddEntry(new Entry(DateTime.Now.ToString(), prompt, entryText));
                    }

                else if (choice =="2")
                {
                    journal.DisplayAll();
                }
                    
                else if(choice == "3")
                { 
                    Console.Write("Enter the file name to load from: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                }

                else if(choice =="4")
                { 
                    Console.Write("Enter the file name to save to: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                }

                else if(choice == "5")
                { 
                    Console.WriteLine("Goodbye!");
                }

                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
