using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Animator animator;
    public AudioSource AudioSource;
    public string triggerName;

    public void Load(int i)
    {
        //Aivar o som "SFX"
        AudioSource.Play();

        // Ativar a animação "PopAnimPlay" antes de carregar a nova cena
        animator.SetTrigger(triggerName);

        // Aguardar a duração da animação (ajuste o tempo de acordo com a animação)
        float animDuration = GetAnimationDuration(triggerName);
        StartCoroutine(LoadSceneAfterDelay(i, animDuration));
    }

    public void Load(string s)
    {
        //Aivar o som "SFX"
        AudioSource.Play();

        // Ativar a animação "PopAnimPlay" antes de carregar a nova cena
        animator.SetTrigger(triggerName);

        // Aguardar a duração da animação (ajuste o tempo de acordo com a animação)
        float animDuration = GetAnimationDuration(triggerName);
        StartCoroutine(LoadSceneAfterDelay(s, animDuration));
    }

    IEnumerator LoadSceneAfterDelay(int i, float delay)
    {
        yield return new WaitForSeconds(delay);

        // Carregar a nova cena após a animação
        SceneManager.LoadScene(i);
    }

    IEnumerator LoadSceneAfterDelay(string s, float delay)
    {
        yield return new WaitForSeconds(delay);

        // Carregar a nova cena após a animação
        SceneManager.LoadScene(s);
    }

    float GetAnimationDuration(string animationName)
    {
        AnimatorClipInfo[] clipInfo = animator.GetCurrentAnimatorClipInfo(0);

        if (clipInfo.Length > 0)
        {
            AnimationClip animClip = clipInfo[0].clip;
            return animClip.length;
        }
        else
        {
            Debug.LogWarning("AnimatorClipInfo array is empty.");
            return 0f;
        }
    }
}
