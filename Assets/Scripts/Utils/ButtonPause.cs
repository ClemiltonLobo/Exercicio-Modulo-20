using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPause : MonoBehaviour
{
    // Referência ao AudioSource que reproduz a música de ambiente
    public AudioSource ambienteAudioSource;

    public void Pause()
    {
        // Pausa o jogo
        Time.timeScale = 0;

        // Pausa a reprodução da música de ambiente
        ambienteAudioSource.Pause();
    }

    public void UnPause()
    {
        // Despausa o jogo
        Time.timeScale = 1;

        // Retoma a reprodução da música de ambiente
        ambienteAudioSource.UnPause();
    }
}
