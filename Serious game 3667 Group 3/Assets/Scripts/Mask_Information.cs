using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mask_Information : MonoBehaviour
{

    GameObject Mask_Panel;
    // Start is called before the first frame update
    void Start()
    {
        Mask_Panel = GameObject.FindGameObjectWithTag("Mask");
        Mask_Panel.SetActive(false);
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }*/

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Mask_Panel.SetActive(true);
    }


}
