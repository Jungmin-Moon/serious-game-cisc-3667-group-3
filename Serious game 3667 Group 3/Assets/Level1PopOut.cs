using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1PopOut : MonoBehaviour
{
    // Start is called before the first frame update
public static bool GameIsPaused = false;
    public GameObject pauseMenuUI; 
    

    //public static bool isMask = false; 
    [SerializeField] PresistentData Mask;

    public void Pause(){
        pauseMenuUI.SetActive(true); 
        Time.timeScale = 0f; 
        GameIsPaused = true; 
    }

    public void Resume(){
        pauseMenuUI.SetActive(false); 
        Time.timeScale = 1f; 
        GameIsPaused = false; 
    }

    public void YesButton(){
        Mask.setMask(); 
        Resume();

    } 

    public void NoButton(){
    Resume();

    } 
}
