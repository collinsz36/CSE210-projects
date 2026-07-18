using System;

public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _hidden = true;
    }
    public void Show()
    {
        _hidden = false;   
    }
    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetDisplayText()
    {
        if (IsHidden())
        {
            return new string('_', _text.Length);
        }
        else
        {
        return _text;
        }
    }
}