using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Bottle_Information : MonoBehaviour
{
    GameObject Water_Bottle_Panel;
    // Start is called before the first frame update
    void Start()
    {
        Water_Bottle_Panel = GameObject.FindGameObjectWithTag("Water_Bottle");
        Water_Bottle_Panel.SetActive(false);
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }*/

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Water_Bottle_Panel.SetActive(true);
    }
}
