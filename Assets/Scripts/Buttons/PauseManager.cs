using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    private bool isPaused;
    private float previousTimeScale;

    [Header("Painel de Pausa")]
    public GameObject pausePanel;
    public string sceneName;

    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            previousTimeScale = Time.timeScale;
            Time.timeScale = 0f;
            pausePanel.SetActive(true);
        }
        else
        {
            Time.timeScale = previousTimeScale;
            pausePanel.SetActive(false);
        }
    }

    public void Resume()
    {
        TogglePause();
    }

    public void QuitToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }
}