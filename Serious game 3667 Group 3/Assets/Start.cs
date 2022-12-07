using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour
{
    public int startScene;

    public void StartGame() {
        SceneManager.LoadScene(startScene);
    }
}
