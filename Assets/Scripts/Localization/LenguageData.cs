using System;
using System.Collections.Generic;

public enum Language
{
    English = 1,
    Catalan,
    Spanish
}

public class LanguageData
{
    private string[] texts;

    public LanguageData(string[] entry)
    {
        texts = new string[entry.Length - 1];
        Array.Copy(entry, 1, texts, 0, texts.Length);
    }

    public string GetText(Language language)
    {
        int index = (int)language;
        return (index >= 0 && index < texts.Length) ? texts[index] : "MISSING";
    }
}
