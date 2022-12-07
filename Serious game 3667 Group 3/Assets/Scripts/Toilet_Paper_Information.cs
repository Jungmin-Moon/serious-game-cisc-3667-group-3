using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet_Paper_Information : MonoBehaviour
{
    GameObject Toilet_Paper_Panel;
    // Start is called before the first frame update
    void Start()
    {
        Toilet_Paper_Panel = GameObject.FindGameObjectWithTag("Toilet_Paper");
        Toilet_Paper_Panel.SetActive(false);
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }*/

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Toilet_Paper_Panel.SetActive(true);
    }
}
