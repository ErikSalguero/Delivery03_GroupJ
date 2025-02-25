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
    // One string per language
   /* public Dictionary<Language, string> Data;

    public LanguageData(string[] rawData)
    {
        Data = new Dictionary<Language, string>();

        for (int i = 1; i < rawData.Length; i++)
        {
            Data.Add((Language)i, rawData[i]);
        }
    }

    public string GetText(Language language)
    {
        return Data[language];
    }*/
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
