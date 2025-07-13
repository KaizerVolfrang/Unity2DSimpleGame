using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text scoreText;
    private int score;
    private AudioSource audio;
    void Start()
    {
        scoreText = GetComponent<Text>();
        audio = GetComponent<AudioSource>();
        RefreshText();
        
    }
    private void OnDisable()
    {
        ReturnProgress();
    }

    public void AddScore()
    {
        score += 1;
        audio.Play();
        RefreshText();
    }

    private void RefreshText()
    {
        scoreText.text = "Score: " + score;
    }

    private void ReturnProgress()
    {
        float barStroll = PlayerPrefs.GetFloat("Stroll");
        barStroll += score * 0.05f;
        PlayerPrefs.SetFloat("Stroll", barStroll);
    }

}
