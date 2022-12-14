using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Grocery_Store_Choice : MonoBehaviour
{

    GameObject Situation_Information, Yes_Choice, No_Choice;


    // Start is called before the first frame update
    void Start()
    {
        Situation_Information = GameObject.FindGameObjectWithTag("TP_Choice");
        Yes_Choice = GameObject.FindGameObjectWithTag("TP_Yes");
        No_Choice = GameObject.FindGameObjectWithTag("TP_No");

        Situation_Information.SetActive(false);
        Yes_Choice.SetActive(false);
        No_Choice.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Situation_Information.SetActive(true);
    }  */

    public void DisplayYesChoice()
    {
        Situation_Information.SetActive(false);
        Yes_Choice.SetActive(true);
    }

    public void DisplayNoChoice()
    {
        Situation_Information.SetActive(false);
        No_Choice.SetActive(true);
    }

    public void GoNextLevel()
    {
        SceneManager.LoadScene(5);
    }
}
