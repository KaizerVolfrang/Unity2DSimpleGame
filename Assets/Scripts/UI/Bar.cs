using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
   [SerializeField] private Image bar;

    private void Start()
    {
        if (PlayerPrefs.HasKey(gameObject.name))
        {
            bar.fillAmount = PlayerPrefs.GetFloat(gameObject.name);  
        }
        
    }
    private void OnDisable()
    {
        PlayerPrefs.SetFloat(gameObject.name, bar.fillAmount);
    }

    public void AddValueBar(float value)
    {
        bar.fillAmount += value;
    }

    public float GetValueBar()
    {
        return bar.fillAmount;
    }
}
