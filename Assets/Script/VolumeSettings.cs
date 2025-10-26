using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider sliderMus;
    [SerializeField] private Slider sliderEff;

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
            SetEffectVolume();
        }
        
    }

    public void SetMusicVolume()
    {
        float volume = sliderMus.value;
        myMixer.SetFloat("music", (volume -80));
        PlayerPrefs.SetFloat("musicVolume", volume);
    }
    
    public void SetEffectVolume()
    {
        float volume = sliderEff.value;
        myMixer.SetFloat("effect", (volume -80));
        PlayerPrefs.SetFloat("effectVolume", volume);
    }

    private void LoadVolume()
    {
        sliderMus.value = PlayerPrefs.GetFloat("musicVolume");
        sliderEff.value = PlayerPrefs.GetFloat("effectVolume");
        SetMusicVolume();
        SetEffectVolume();
    }
}