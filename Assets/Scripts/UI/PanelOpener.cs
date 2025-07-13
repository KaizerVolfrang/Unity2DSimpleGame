using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnablePanel()
    {
        gameObject.SetActive (true);
    }

    public void DisablePanel() 
    {
        gameObject.SetActive(false);
    }

    public void EnableAndDisablePanel()
    {
        bool isActive = gameObject.activeSelf;
        gameObject.SetActive(!isActive);
    }
}
