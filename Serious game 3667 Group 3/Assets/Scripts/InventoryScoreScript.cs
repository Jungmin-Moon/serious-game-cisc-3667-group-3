using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class InventoryScoreScript : MonoBehaviour
{
    int score = 0; 
    [SerializeField] TextMeshProUGUI  scoreText;
    // Start is called before the first frame update

    public void AddScore(){

        score += 1;

        scoreText.text = score.ToString();  

    }
}
