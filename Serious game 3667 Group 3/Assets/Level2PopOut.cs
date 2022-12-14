using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Level2PopOut : MonoBehaviour

{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI; 
    public GameObject person1;
    [SerializeField] PresistentData Score;
    

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
        Score.AddScoreHP(30); 
        person1.GetComponent<Collider2D>().enabled = false; 
        //SceneManager.LoadScene("Grocery_Store");
        //Debug.Log("YES BUTTON PRESSED");

    } 

    public void NoButton(){
        Resume();
        Destroy(person1); 
        //SceneManager.LoadScene("Grocery_Store");
        //Debug.Log("No BUTTON PRESSED");

    } 
}
