using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person1Script : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] HPScoreScript Score;
    [SerializeField] Level2PopOut PopOutWindow;
    public GameObject person1; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collison){
         
        if(collison.gameObject.tag == "Player"){
           
            //Score.AddScore(20);
            PopOutWindow.Pause(); 
            
             
        }
    }
}
