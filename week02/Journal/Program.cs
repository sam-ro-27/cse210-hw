using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        //dear diary, today I learned about classes and objects in C#.
        // I created a class called Entry that has three properties: _Date, _Prompt, and _Entry.
        //  I also created a class called Journal that has a list of Entry objects.
        //  I can create new Entry objects and add them to the Journal's list of entries. 
        // This is a great way to organize my thoughts and keep track of my daily activities.
        Entry myEntry = new Entry();
        DateTime currentDate = DateTime.Now;
        myEntry._Date = currentDate.ToString("11/07/2026");
        myEntry._Prompt = "What did you learn today?";
        myEntry._Entry = "I learned about classes and objects in C#.";
        Journal myJournal = new Journal();
        myJournal._Entries.Add(myEntry);
        Console.WriteLine("myEntry._Date: " + myEntry._Date);
        Console.WriteLine("myEntry._Prompt: " + myEntry._Prompt);
        Console.WriteLine("myEntry._Entry: " + myEntry._Entry);
    }
}