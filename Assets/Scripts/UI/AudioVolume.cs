using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioVolume : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource buttonSource;
    [SerializeField] private AudioSource dogSource;
    [SerializeField] private AudioSource scoreSource;

    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat(gameObject.name);
        SetAudioVolume();
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat(gameObject.name, slider.value);
    }

    public void SetAudioVolume()
    {
        musicSource.volume = slider.value;
        buttonSource.volume = slider.value;
        dogSource.volume = slider.value;

        if (scoreSource != null)
        {
            scoreSource.volume = slider.value;
        }
    }
}
