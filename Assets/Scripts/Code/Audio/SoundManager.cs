using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

    // declaring private variables which will be given values in the editor
    // the values are goind to be the actual sliders

    [SerializeField]
    private Slider musicSlider;

    [SerializeField]
    private Slider effectsSlider;

    [SerializeField]
    private AudioSource musicSource;

    [SerializeField]
    private AudioSource effectsSource;

    // Start is called before the first frame update
    void Start()
    {
        if ( !PlayerPrefs.HasKey("musicVolume") ) {
            PlayerPrefs.SetFloat("musicVolume", 0.5f);  // the default volume is goind to be 50%
            Load();
        }
    }

    public void ChangeVolume() {
        musicSource.volume = musicSlider.value; // background music
        effectsSource.volume = effectsSlider.value; // sound effects
        Save();

        // Debug.Log("sound effects: ", effectsSource.volume);
    }

    private void Load() {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");   // sets the volume to the previously saved one if there is one, otherwise it is going to be 50%
    }

    private void Save() {
        PlayerPrefs.SetFloat("musicVolume", musicSlider.value); // saves the volume to be the newest one chosen
    }
}
