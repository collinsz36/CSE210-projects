using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _words = new List<Word>();

        string[] parts = text.Split(' ');

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> Words = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                Words.Add(word);
            }
        }

        if (Words.Count == 0)
        {
            return;
        }

        for (int i = 0; i < numberToHide && Words.Count > 0; i++)
        {
            int index = _random.Next(Words.Count);

            Words[index].Hide();

            Words.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string text = "";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return ($"{_reference.GetDisplayText()} {text}");
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}