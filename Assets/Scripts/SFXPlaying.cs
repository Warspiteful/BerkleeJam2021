using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Plays click audio source as SFX
public class SFXPlaying : MonoBehaviour
{
   public AudioSource Click;
   
   public void PlayClick() {
       Click.Play();
   }
}
