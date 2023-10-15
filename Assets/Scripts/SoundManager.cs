using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume")) {
        PlayerPrefs.SetFloat("musicVolume", 1);
        Load();
        }
        else {
        Load();
        }
    }

    public void changeVolume() {
    AudioListener.volume = volumeSlider.value;
    Save();
    }

    private void Load() {
    volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    // Update is called once per frame
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}