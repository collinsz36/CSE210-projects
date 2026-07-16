using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
    _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
    _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        if (_entries.Count==0)
            {
            Console.WriteLine("No journal entries found!");
            return;
            }

        foreach (Entry entry in _entries)
            {
            entry.Display();
            }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
            writer.WriteLine($"{entry._date}|{entry._mood}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries.Clear();

        using (StreamReader reader = new StreamReader(file))
        {
            while (!reader.EndOfStream)
            {
            string line = reader.ReadLine();
            string[] parts = line.Split('|');

            if (parts.Length == 4)
            {
                Entry entry = new Entry();

                entry._date = parts[0];
                entry._mood = parts[1];
                entry._promptText = parts[2];
                entry._entryText = parts[3];

                _entries.Add(entry);
            }
        }
    }
}

    public void SearchEntries(string keyword)
    {
        bool found = false;

        foreach (Entry entry in _entries)
        {
            if (entry._entryText.ToLower().Contains(keyword.ToLower()) ||
                entry._promptText.ToLower().Contains(keyword.ToLower()) ||
                entry._mood.ToLower().Contains(keyword.ToLower()))
            {
                entry.Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching journal entries found.");
        }
    }
}
    
