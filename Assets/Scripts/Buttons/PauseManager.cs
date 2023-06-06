using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    private bool isPaused;    

    [Header("Painel de Pausa")]
    public GameObject pausePanel;
    public GameObject TextPause;
    public GameObject ButtonBackMenu;
    
    public AudioSource ambienteAudioSource;

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
            TextPause.SetActive(true);
            ButtonBackMenu.SetActive(true);            
            ambienteAudioSource.Pause();
        }
        else
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
            TextPause.SetActive(false);
            ButtonBackMenu.SetActive(false);
            ambienteAudioSource.UnPause();
        }
    }

    public void Resume()
    {
        TogglePause();
    }
}