using UnityEngine;
using UnityEngine.UI;

public class LanguageDropdown : MonoBehaviour
{
    public Dropdown languageDropdown; // Arrástralo en el Inspector

    private void Start()
    {
        if (languageDropdown == null)
        {
            Debug.LogError("No se ha asignado un Dropdown en el Inspector.");
            return;
        }

        languageDropdown.ClearOptions();
        languageDropdown.AddOptions(new System.Collections.Generic.List<string> { "English", "Catalan", "Spanish" });

        int savedLanguageIndex = PlayerPrefs.GetInt("SelectedLanguage", 0);
        languageDropdown.value = savedLanguageIndex;

        languageDropdown.onValueChanged.AddListener(ChangeLanguage);
    }

    private void ChangeLanguage(int index)
    {
        Language selectedLanguage = (Language)index;
        Localizer.SetLanguage(selectedLanguage);
    }
}