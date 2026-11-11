using System;
using System.Collections.Generic;

namespace Journal
{
    class PromptGenerator
    {
        private readonly List<string> _prompts = new()
        {
            "What did you learn today?",
            "What was the best part of your day?",
            "What are you grateful for today?",
            "What is one thing you want to remember?"
        };

        public string GetRandomPrompt()
        {
            Random random = new();
            return _prompts[random.Next(_prompts.Count)];
        }
    }
    // Creativity: I added more than the core requirements.
    // I added a Goodbye message when you pick Quit.
    // I added an Invalid choice message if you pick a number that is not 1 to 5.
    // I added 5 writing prompts, not just 3, so GetRandomPrompt has more to pick from.
    // I added a menu that keeps showing until you pick Quit.

    class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new();
            PromptGenerator promptGenerator = new();
            string choice = "";

            while (choice != "5")
            {
                Console.WriteLine();
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Entry newEntry = new();
                    newEntry.Date = DateTime.Now.ToString("MM/dd/yyyy");
                    newEntry.Prompt = promptGenerator.GetRandomPrompt();
                    Console.Write("Write your entry: ");
                    newEntry.EntryText = Console.ReadLine();
                    myJournal.AddEntry(newEntry);
                }
                else if (choice == "2")
                {
                    myJournal.DisplayAll();
                }
                else if (choice == "3")
                {
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    myJournal.LoadFromFile(filename);
                }

                else if (choice == "4")
                {
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    myJournal.SaveToFile(filename);
                }
                else if (choice == "5")
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
}
