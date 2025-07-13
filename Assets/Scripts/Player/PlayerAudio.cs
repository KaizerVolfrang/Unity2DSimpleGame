using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField] private AudioClip barking_0;
    [SerializeField] private AudioClip barking_1;
    [SerializeField] private AudioClip barking_2;
    [SerializeField] private AudioClip breath;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OneBarking()
    {
        audioSource.clip = barking_0;
        audioSource.Play();
    }

    public void TripleBarking()
    {
        audioSource.clip = barking_2;
        if (audioSource.isPlaying)
        {
            return;
        }
        audioSource.Play();
    }

    public void Breath()
    {
        audioSource.clip = breath;
        if (audioSource.isPlaying)
        {
            return;
        }
        audioSource.Play();
    }
}
