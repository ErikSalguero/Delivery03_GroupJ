using System;
using System.Collections.Generic;
using UnityEngine;

public class Localizer : MonoBehaviour
{
    public static Localizer Instance; 

    public TextAsset DataSheet; 

    Dictionary<string, LanguageData> Data; 

    private Language currentLanguage;
    public Language DefaultLanguage;

    public static Action OnLanguageChange; 

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
        } 
        currentLanguage = (Language)PlayerPrefs.GetInt("SelectedLanguage", (int)DefaultLanguage);

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
        Data = new Dictionary<string, LanguageData>();
        string[] lines = DataSheet.text.Split(new char[] { '\n' });

        for (int i = 1; i < lines.Length; i++)
        {
            if (lines.Length > 1) AddLanguageData(lines[i]);
        }
    }

    void AddLanguageData(string str)
    {
        string[] entry = str.Split(new char[] { ';' });

        if (entry.Length < 2) return;

        var languageData = new LanguageData(entry);

        Data.Add(entry[0], languageData);
    }
}
