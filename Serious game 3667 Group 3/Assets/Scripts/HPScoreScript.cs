using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class HPScoreScript : MonoBehaviour
{
    int score = 100; 
    [SerializeField] TextMeshProUGUI  scoreText; 

    public void AddScore(int i){

        score -= i;

        scoreText.text = score.ToString();  

    }


}
