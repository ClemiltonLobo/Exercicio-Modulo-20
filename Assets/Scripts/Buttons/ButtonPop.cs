using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPop : MonoBehaviour
{
    public RectTransform buttonTransform;
    public Animator buttonAnimator;
    public string popAnimationName = "PopAnim";
    public string idleAnimationName = "IdleAnim";

    private bool isPopped = false;

    void Awake()
    {
        buttonTransform = GetComponent<RectTransform>();
        buttonAnimator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        if (!isPopped)
        {
            // Iniciar animação de estouro
            buttonAnimator.Play(popAnimationName);

            // Definir o estado como estourado
            isPopped = true;
        }
    }

    void OnMouseUp()
    {
        // Parar a animação de estouro
        buttonAnimator.enabled = false;

        // Iniciar a animação de retorno ao estado normal
        buttonAnimator.Play(idleAnimationName);

        // Definir o estado como não estourado
        isPopped = false;
    }
}

