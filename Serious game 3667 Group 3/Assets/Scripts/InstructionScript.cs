using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InstructionScript : MonoBehaviour
{
    public GameObject instructionsScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void OpenInstructions()
    {
        instructionsScreen.SetActive(true);
    }

    public void CloseInstructions()
    {
        instructionsScreen.SetActive(false);
    }
}
