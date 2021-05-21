using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransEcra : MonoBehaviour
{
    [SerializeField] Image blackScreen;
    [SerializeField] float tempoTransicaoPreto;

    private void Awake()
    {
        FadeFromBlack();
    }

    void FadeToBlack()
    {
        blackScreen.color = Color.black;
        blackScreen.canvasRenderer.SetAlpha(0.0f);
        blackScreen.CrossFadeAlpha(1.0f, tempoTransicaoPreto, false);
    }

    void FadeFromBlack()
    {
        blackScreen.color = Color.black;
        blackScreen.canvasRenderer.SetAlpha(1.0f);
        blackScreen.CrossFadeAlpha(0.0f, tempoTransicaoPreto, false);
    }
}
