using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using System.Globalization;


public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volSlide;

    void Start(){
      
        //affichage volume
        audioMixer.SetFloat("volume", PlayerPrefs.GetFloat("volume"));
        audioMixer.GetFloat("volume", out float vol);
        volSlide.value = vol;
    }

    public void SetVolume(float volume){
        audioMixer.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("volume", volume);
    }
}
