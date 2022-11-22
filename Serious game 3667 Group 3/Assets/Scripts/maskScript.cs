using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maskScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] InventoryScoreScript Score;
    [SerializeField] AudioSource audioPlayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collison){
         
        if(collison.gameObject.tag == "Variant"){
            
            Score.AddScore();
            GameObject.Find("MaskSound").GetComponent<maskSound>().playAudio();
            Destroy(this.gameObject); 
             
        }
    }
}
