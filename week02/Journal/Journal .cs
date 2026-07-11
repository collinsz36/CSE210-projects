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
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        StreamWriter writer = new StreamWriter(file);

        foreach (Entry entry in _entries)
        {
            writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
        }

        writer.Close();
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        
        

        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();

            string[] parts = line.Split('|');

            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }

        reader.Close();
    }
}