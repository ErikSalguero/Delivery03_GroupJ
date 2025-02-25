using System;
using System.Collections.Generic;
using UnityEngine;

public class Localizer : MonoBehaviour
{
    public static Localizer Instance; // Singleton instance of Localizer

    public TextAsset DataSheet; // Unity text asset to be assigned (.csv)

    Dictionary<string, LanguageData> Data; // Text data from CSV

    private Language currentLanguage;
    public Language DefaultLanguage;

    public static Action OnLanguageChange; // Change language event

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        } //prob
        //currentLanguage = DefaultLanguage;
        currentLanguage = (Language)PlayerPrefs.GetInt("SelectedLanguage", (int)DefaultLanguage);//prob

        LoadLanguageSheet();
    }

    public static string GetText(string textKey)
    {
        if (Instance.Data.ContainsKey(textKey))
            return Instance.Data[textKey].GetText(Instance.currentLanguage);

        return textKey;
    }

    public static void SetLanguage(Language language)
    {
        Instance.currentLanguage = language;
        PlayerPrefs.SetInt("SelectedLanguage", (int)language);
        PlayerPrefs.Save();
        OnLanguageChange?.Invoke();
    }

    void LoadLanguageSheet()
    {
        Data = new Dictionary<string, LanguageData>();//prob
        string[] lines = DataSheet.text.Split(new char[] { '\n' });

        for (int i = 1; i < lines.Length; i++)
        {
            if (lines.Length > 1) AddLanguageData(lines[i]);
        }
    }

    void AddLanguageData(string str)
    {
        string[] entry = str.Split(new char[] { ';' });

        if (entry.Length < 2) return;//prob

        var languageData = new LanguageData(entry);

        //if (Data == null) Data = new Dictionary<string, LanguageData>();

        Data.Add(entry[0], languageData);
    }
}
