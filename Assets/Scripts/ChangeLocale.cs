using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ChangeLocale : MonoBehaviour
{

    public void SetLanguage(int _locale_ID)
    {
        StartCoroutine(SetLocale(_locale_ID));
    }
    
    private IEnumerator SetLocale(int _locale_ID)
    {
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_locale_ID];
    }
}
