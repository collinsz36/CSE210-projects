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
    public void PrintSignature()
    {
    Console.WriteLine("========================================");
    Console.WriteLine("     Collins' Personal Journal");
    Console.WriteLine("     Keep Writing. Keep Growing.");
    Console.WriteLine("========================================");
    Console.WriteLine();
    }
    public void DisplayAll()
{
    PrintSignature();

    foreach (Entry entry in _entries)
    {
        entry.Display();
    }

    Console.WriteLine();
    Console.WriteLine("Dont forget to pray!");
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

        StreamReader reader = new StreamReader(file);

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