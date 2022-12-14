using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; 
public class PresistentData : MonoBehaviour
{

    public static PresistentData control; 
    
    [SerializeField] TextMeshProUGUI  scoreTextHP; 
    //[SerializeField] Level1PopOut  mask; 

    

    public static int  HPScore = 100;
    public static bool isMask = false; 
    private float timer;
    private void Awake(){

        
        scoreTextHP.text = HPScore.ToString();  
         
        if(control == null){
            control = this;
            DontDestroyOnLoad(gameObject);
        } else if (control != this){
            Destroy(gameObject); 
        }
    }

    public void AddScoreHP(int i){

        HPScore -= i;

        scoreTextHP.text = HPScore.ToString();  

        if(HPScore <= 0){

            HPScore = 100;
            SceneManager.LoadScene("Level1");
             
        }

    }


    public void setMask(){

        isMask = true; 
        Debug.Log("Presistent Data for mask "+isMask); 
    }

    public bool GetMask(){

        return isMask; 
    }

    public int GetHPScore(){
    
        return HPScore;
    }
}
