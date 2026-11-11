namespace Journal
{
   public class Journal
   {
      public List<Entry> Entries { get; set; } = new();

      public void AddEntry(Entry newEntry)
      {
         Entries.Add(newEntry);
      }

      public void DisplayAll()
      {
         foreach (Entry entry in Entries)
         {
            entry.Display();
         }
      }

      public void SaveToFile(string filename)
      {
         using StreamWriter outputFile = new(filename);
         foreach (Entry entry in Entries)
         {
            outputFile.WriteLine($"{entry.Date}~{entry.Prompt}~{entry.EntryText}");
         }
      }

      public void LoadFromFile(string filename)
      {
         string[] lines = File.ReadAllLines(filename);
         foreach (string line in lines)
         {
            string[] parts = line.Split('~');
            Entry newEntry = new()
            {
               Date = parts[0],
               Prompt = parts[1],
               EntryText = parts[2]
            };
            Entries.Add(newEntry);
         }
      }
   }
}
