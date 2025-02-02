using System.IO;

class Journal
{

    public List<Entry> entires = new List<Entry>();



    public void AddEntry()
    {
        Entry entry = new Entry();
        entry.CreateEntry();
        entires.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entires)
        {
            entry.DisplayEntry();
        }
    }
    
    public void Load(string[] args = null)
    {
        Console.WriteLine("What is the name of your file?");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(", ");

            Entry entry = new Entry();
            entry.date = parts[0];
            entry.prompt = parts[1];
            entry.answer = parts[2];

            entires.Add(entry);
        }

        Console.WriteLine("Loaded Entries:");
        foreach (Entry entry in entires)
        {
            Console.WriteLine($"{entry.date}, {entry.prompt}, {entry.answer}");
        }
    }

    public void Save(string[] args = null)
    {
        Console.WriteLine("What is the name of your file?");
        string filename = Console.ReadLine();
       

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            
            foreach (Entry entry in entires)
            {
                outputFile.WriteLine($"{entry.date}, {entry.prompt}, {entry.answer}"); 
            }
        }

        Console.WriteLine($"Your journal has been saved to {filename}");
    }
}