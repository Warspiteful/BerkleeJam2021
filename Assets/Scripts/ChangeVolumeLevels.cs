using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolumeLevels : MonoBehaviour
{

    public Slider thisSlider;
    public float masterVolume;
    public float musicVolume;
    public float SFXVolume;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSpecificVolume(string whatValue)
    {
        float sliderValue = thisSlider.value;

        if (whatValue == "Master")
        {
            //Debug.Log("changed Master Volume to :" + thisSlider.value);
            masterVolume = thisSlider.value;
            AkSoundEngine.SetRTPCValue("MasterVolume", masterVolume);
        }

        if (whatValue == "Music")
        {
            //Debug.Log("changed music Volume to :" + thisSlider.value);
            musicVolume = thisSlider.value;
            AkSoundEngine.SetRTPCValue("MusicVolume", musicVolume);
        }

        if (whatValue == "SFX")
        {
            //Debug.Log("changed SFX Volume to :" + thisSlider.value);
            SFXVolume = thisSlider.value;
            AkSoundEngine.SetRTPCValue("SFXVolume", masterVolume);
        }
    }
}
