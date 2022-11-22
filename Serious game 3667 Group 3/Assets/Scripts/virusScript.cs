using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virusScript : MonoBehaviour
{
    
    [SerializeField] Vector3 force; 
    [SerializeField] HPScoreScript Score;
    [SerializeField] AudioSource audioPlayer;

    private Rigidbody2D rb; 
    private SpriteRenderer spriteRenderer; 
    Vector3 LastVelocity;
    
     
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        force = new Vector3(Random.Range(-300,300),Random.Range(350,450),0);
        rb.AddForce(force); 
         
        
    }

    // Update is called once per frame
    void Update()
    {
        // Finding the last velocity of the balloon
        LastVelocity = rb.velocity;
        
    
    }
        public void OnCollisionEnter2D(Collision2D collision)
    {
        // Finding the speed
        var speed = LastVelocity.magnitude;
        // Finding and applying the direction of the balloons
        var direction = Vector3.Reflect(LastVelocity.normalized, collision.contacts[0].normal);
        // The Maximum value is applied
        rb.velocity = direction * Mathf.Max(speed, 0f);



    }

  
    private void OnTriggerEnter2D(Collider2D collison){
         
        if(collison.gameObject.tag == "Variant"){
            
            Score.AddScore(10);
            GameObject.Find("VirusSound").GetComponent<virusSound>().playAudio(); 
            Destroy(this.gameObject); 
            
        }
    }
}

