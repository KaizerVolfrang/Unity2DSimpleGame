using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadHome()
    {
        SceneManager.LoadScene("Home");
    }

    public void LoadStreet()
    {
        SceneManager.LoadScene("Street");
    }
   
}
