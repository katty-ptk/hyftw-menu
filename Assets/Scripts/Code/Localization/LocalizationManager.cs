using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization.Settings;

public class LocalizationManager : MonoBehaviour
{
    [SerializeField] private Button selectLanguage;
    [SerializeField] private GameObject ro;
    [SerializeField] private GameObject en;

    public void ToggleActive() {
        bool isActive = ro.activeSelf;  // if the ro button is inactive, the en button is also

        // toggles the activity of both of them
        ro.SetActive(!isActive);      
        en.SetActive(!isActive);
    }

    public void changeToRo() {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[1];
    }

    public void changeToEn() {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
    }
}