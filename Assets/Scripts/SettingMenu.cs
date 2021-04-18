using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer;   

    //Adapts volume level to slider value
    public void SetMasterVolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        Debug.Log(volume);
    }

public void SetSFXVolume (float volume)
    {
        audioMixer.SetFloat("SFXVolume", volume);
        Debug.Log(volume);
    }

public void SetMusicVolume (float volume)
    {
        audioMixer.SetFloat("MusicVolume", volume);
        Debug.Log(volume);
    }


}
