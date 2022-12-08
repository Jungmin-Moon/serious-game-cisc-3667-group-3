using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Mask : MonoBehaviour

{
    [SerializeField] Level1PopOut PopOutWindow;

    public bool isMask = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collison){
         
        if(collison.gameObject.tag == "Player"){
           
             Destroy(this.gameObject); 
             PopOutWindow.Pause(); 

            
             
        }
     }

    // Update is called once per frame
    void Update()
    {
        
    }


}
