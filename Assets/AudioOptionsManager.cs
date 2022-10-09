using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class AudioOptionsManager : MonoBehaviour
{
    public AudioMixer audioMixer;

    public static float MusicVolume { get; private set; }
    public static float SEVolume { get; private set; }

    [SerializeField] private TextMeshProUGUI music_Volume;
    [SerializeField] private TextMeshProUGUI se_Volume;

    public void OnMusicSliderValueChange(float value)
    {
        MusicVolume = value;
        music_Volume.text = ((int)(value * 100)).ToString();
        audioMixer.SetFloat("musicVolume1", (float)(Mathf.Log10(value) * 20));
    }
    public void OnSESliderValueChange(float value)
    {
        SEVolume = value;
        se_Volume.text = ((int)(value * 100)).ToString();
        audioMixer.SetFloat("seVolume1", (float)(Mathf.Log10(value) * 20));
    }
}