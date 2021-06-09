using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jogador : MonoBehaviour
{
    private float Tempo = 0f;

    [SerializeField] float TempoEsperaTransporte = 2f;

    [SerializeField] Image blackScreen;
    [SerializeField] float tempoTransicaoPreto;

    private void Awake()
    {
        FadeFromBlack();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "TriggerLab")
        {
            FadeToBlack();
        }

        if (other.tag == "TriggerPass")
        {
            FadeToBlack();
        }
        
        if (other.tag == "TriggerMin")
        {
            FadeToBlack();
        }

        if (other.CompareTag("Porta1"))
        {
            other.GetComponent<AudioSource>().Play();
        }

        if (other.CompareTag("Porta2"))
        {
            other.GetComponent<AudioSource>().Play();
        }
        if (other.CompareTag("Porta3"))
        {
            other.GetComponent<AudioSource>().Play();
        }

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

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Porta1"))
        {
            other.GetComponent<AudioSource>().Stop();
        }

        if (other.CompareTag("Porta2"))
        {
            other.GetComponent<AudioSource>().Stop();
        }

        if (other.CompareTag("Porta3"))
        {
            other.GetComponent<AudioSource>().Stop();
        }       
    }
}

