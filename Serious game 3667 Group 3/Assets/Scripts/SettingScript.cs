using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SettingScript : MonoBehaviour
{
    public GameObject optionsScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void OpenSettings()
    {
        optionsScreen.SetActive(true);
    }

    public void CloseSettings()
    {
        optionsScreen.SetActive(false);
    }
}
