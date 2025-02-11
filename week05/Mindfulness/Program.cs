using System;
//Menu with 4 options(breathing, reflecting, listing or quit)
public class Program
{
    static void Main(string[] args)
    {   
        while (true)
        {
            
                Console.WriteLine ("Menu Options:");

                Console.WriteLine ("1. Start breathing activity");  
                Console.WriteLine ("2. Start reflecting activity");  
                Console.WriteLine ("3. Start listing activity");  
                Console.WriteLine ("4. Quit");                        

                Console.WriteLine ("Select a choice from the menu: ");
                int selectedOption = Convert.ToInt32(Console.ReadLine());
            

            if (selectedOption == 1)
            {
                BreathingActivity a1=new BreathingActivity("Breathing Activity", "Description", 5);//ACA VA EL INPUT QUE EL USUARIO PONE
                Console.WriteLine ($"{a1.DisplayStartingMessage}");
                a1.Run();
                Console.WriteLine($"{a1.DisplayEndingMessage}");      
            }
            else if (selectedOption == 2)
            {
                BreathingActivity a2=new BreathingActivity("Reflecting Activity", "Description", 5);
                Console.WriteLine ($"{a2.DisplayStartingMessage}");
                a2.Run();
                Console.WriteLine($"{a2.DisplayEndingMessage}");   
            }    
            else if (selectedOption == 3)
            {
                BreathingActivity a3=new BreathingActivity("Listing Activity", "Description", 5);
                Console.WriteLine ($"{a3.DisplayStartingMessage}");
                a3.Run();
                Console.WriteLine($"{a3.DisplayEndingMessage}");   
            }  
            else if (selectedOption == 4)
            {
                Console.WriteLine("Thank you for your time");
            } 
            else
            {
                Console.WriteLine("Please insert a valid option");
            }
        }    
    }     
}