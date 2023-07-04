using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocalSelector : MonoBehaviour
{
    private bool _active = false;
  
    public void ChangeLocal(int localeID)
    {
        if (_active) return;
        StartCoroutine(SetLocal(localeID)); 
    }
    IEnumerator SetLocal(int _localeID)
    {
        _active = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID];
        _active = false;
    }
}
