using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP_Choice_Settings : MonoBehaviour
{

    [SerializeField] GameObject Situation_Information;
    // Start is called before the first frame update
    // void Start()
    // {
    //     Situation_Information = GameObject.FindGameObjectWithTag("TP_Choice");
    // }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;
        Situation_Information.SetActive(true);
    }
}
