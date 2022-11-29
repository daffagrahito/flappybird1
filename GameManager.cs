using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ 
    public GameObject startButton;

    public GameObject gameOverCanvas;

    public void Start()
    {
        Time.timeScale = 1;
    }

    public void StartGame()
    {
        startButton.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
