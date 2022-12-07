using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand_Sanitizer_Information : MonoBehaviour
{
    GameObject Hand_Sanitizer_Panel;
    
    // Start is called before the first frame update
    void Start()
    {
        Hand_Sanitizer_Panel = GameObject.FindGameObjectWithTag("Hand_Sanitizer");
        Hand_Sanitizer_Panel.SetActive(false);
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    } */

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Hand_Sanitizer_Panel.SetActive(true);
        //Destroy(gameObject);
        /*
        if(gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Hand_Sanitizer").SetActive(true);
            Destroy(gameObject);
        } */
    }
}
