using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioMaster : MonoBehaviour
{
    Slider slider;
    public string type;
    public float volume = 1;
    private void Start()
    {
        slider = GetComponent<Slider>();
        volume = slider.value;
    }
    public void SetBusVolume()
    {
        volume = slider.value;
        AkSoundEngine.SetRTPCValue(type, volume*100);
    }

}

