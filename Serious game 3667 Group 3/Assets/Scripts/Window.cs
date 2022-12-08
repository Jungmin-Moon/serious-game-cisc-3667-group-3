using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    public static bool windowOpened = false;
    public GameObject Message;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Message.SetActive(true);
        }
    }

    // private void OnTriggerExit2D(Collider2D other)
    // {
    //     if (other.gameObject.tag == "Player")
    //     {
    //         Message.SetActive(false);
    //     }
    // }

    // Update is called once per frame
    void Update()
    {

    }

    public void Exit()
    {
        Message.SetActive(false);
        Time.timeScale = 1f;
        windowOpened = false;
    }
}