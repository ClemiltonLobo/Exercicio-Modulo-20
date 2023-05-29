using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    private bool isPaused;    

    [Header("Painel de Pausa")]
    public GameObject pausePanel;
    public string sceneName;

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
        }
    }

    public void Resume()
    {
        TogglePause();
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene(sceneName);
    }
}