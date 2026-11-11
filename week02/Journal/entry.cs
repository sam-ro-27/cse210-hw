using System;

namespace Journal;

public class Entry
{
    public string Date { get; set; } = string.Empty;
    public string Prompt { get; set; } = string.Empty;
    public string EntryText { get; set; } = string.Empty;

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Entry: {EntryText}");
    }
}

