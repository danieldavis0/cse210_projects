// For my creative additions I have added logic to the PromptGenerator class to ensure the same prompt will not show
// up for the user twice in a row. This is done by saving the last used prompt to variable, which will be checked against
// the next prompt generated.

using System;

class Program
{
    static void Main(string[] args)
    {
        bool runLoop = true;
        string userInput = "";
        string mostRecentPrompt = "";
        Journal journal = new Journal();
        
        Console.WriteLine("Welcome to the Journal Program!");

        while (runLoop)
        {
            Console.WriteLine("Please select one of the following options: \n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do? ");

            while (userInput != "1" && userInput != "2" && userInput != "3" &&userInput != "4" && userInput != "5")
            {
                userInput = Console.ReadLine();
                if (userInput != "1" && userInput != "2" && userInput != "3" &&userInput != "4" && userInput != "5")
                {
                    Console.WriteLine("Please enter a valid input.");
                }
            }

            if (userInput == "1")
            {
                Entry entry = new Entry();
                PromptGenerator prompt = new PromptGenerator();
                string newPrompt = prompt.GetRandomPrompt(mostRecentPrompt);
                mostRecentPrompt = newPrompt;
                Console.WriteLine(newPrompt);
                userInput = Console.ReadLine();
                entry._promptText = newPrompt;
                entry._entryText = userInput;
                DateTime currentTime = DateTime.Now;
                string timeStamp = currentTime.ToShortDateString();
                entry._date = timeStamp;
                journal.AddEntry(entry);
            }

            else if (userInput == "2")
            {
                journal.DisplayAll();
            }

            else if (userInput == "3")
            {
                Console.WriteLine("What is the filename?");
                userInput = Console.ReadLine();
                journal.LoadFromFile(userInput);
            }

            else if (userInput == "4")
            {
                Console.WriteLine("What is the filename?");
                userInput = Console.ReadLine();
                journal.SaveToFile(userInput);
            }

            else if (userInput == "5")
            {
                runLoop = false;
            }

            userInput = "";
        }
    }
}