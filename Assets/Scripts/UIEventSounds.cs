using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIEventSounds : MonoBehaviour, IPointerClickHandler

{
    public AK.Wwise.Event OnPointerClickSound;

    public void OnPointerClick(PointerEventData eventData)
    {
        OnPointerClickSound.Post(gameObject);
    }
}
