using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class Level2PopOut : MonoBehaviour

{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI; 
    

    bool isCollide = false; 


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
        Resume();
        SceneManager.LoadScene("Grocery_Store");
        //Debug.Log("YES BUTTON PRESSED");

    } 

    public void NoButton(){
        Resume();
        SceneManager.LoadScene("Grocery_Store");
        //Debug.Log("No BUTTON PRESSED");

    } 
}
