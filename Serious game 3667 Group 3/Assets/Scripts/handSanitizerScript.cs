using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handSanitizerScript : MonoBehaviour
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
                GameObject.Find("HandSanitizerSound").GetComponent<handSanitizerSound>().playAudio();
                Destroy(this.gameObject); 
                
            }
        }
}
