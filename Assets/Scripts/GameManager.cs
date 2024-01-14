using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject gameOverPanel;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void TriggerGameOver()
    {
        gameOverPanel.SetActive(true);
        // Additional logic if needed
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
