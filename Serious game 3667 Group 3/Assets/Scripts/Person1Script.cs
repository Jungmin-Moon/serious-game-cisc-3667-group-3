using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person1Script : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] HPScoreScript Score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collison){
         
        if(collison.gameObject.tag == "Variant"){
            
           Score.AddScore(20);
             
        }
    }
}
