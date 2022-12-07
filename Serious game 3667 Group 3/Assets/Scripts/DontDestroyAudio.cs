using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class DontDestroyAudio : MonoBehaviour
{
    public static DontDestroyAudio instance;
 
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
 