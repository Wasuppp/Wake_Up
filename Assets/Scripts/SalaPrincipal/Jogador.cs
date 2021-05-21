using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jogador : MonoBehaviour
{
    [SerializeField] Progresso Progresso;

    private float Tempo = 0f;

    [SerializeField] float TempoEsperaTransporte = 2f;

    [SerializeField] Image blackScreen;
    [SerializeField] float tempoTransicaoPreto;

    bool DentroPortalLab = false; // O jogador está dentro do portal
    bool BloquearNivelLabirinto = false;

    bool DentroPortalPass = false;
    bool BloquearNivelPassagens = false;

    bool DentroPortalMin = false;
    bool BloquearNivelMinijogos = false;

    private void Awake()
    {
        FadeFromBlack();
    }


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "TriggerLab" && BloquearNivelLabirinto == false)
        {
            DentroPortalLab = true;
            Progresso.InstanciaUrso();
            BloquearNivelLabirinto = true;
            FadeToBlack();

        }
        if (other.tag == "TriggerPass" && BloquearNivelPassagens == false)
        {
            DentroPortalPass = true;
            Progresso.InstanciaPapeis();
            BloquearNivelPassagens = true;
            FadeToBlack();

        }
        
        if (other.tag == "TriggerMin" && BloquearNivelMinijogos == false)
        {
            DentroPortalMin = true;
            Progresso.InstanciaTelemovel();
            BloquearNivelMinijogos = true;
            FadeToBlack();
        }

    }


    private void Update()
    {
        if (DentroPortalLab == true)
        {
            Tempo += Time.deltaTime;

            if (Tempo >= TempoEsperaTransporte) // se o jogador estiver dentro do portal mais de 2 segundos, é teletransportado para o nivel
            {
                TransporteLabirinto();
            }
        }

        if (DentroPortalPass == true)
        {
            Tempo += Time.deltaTime;

            if (Tempo >= TempoEsperaTransporte) // se o jogador estiver dentro do portal mais de 2 segundos, é teletransportado para o nivel
            {
                TransportePassagens();
            }
        }

        if (DentroPortalMin == true)
        {
            Tempo += Time.deltaTime;

            if (Tempo >= TempoEsperaTransporte) // se o jogador estiver dentro do portal mais de 2 segundos, é teletransportado para o nivel
            {
                TranporteMinijogos();
            }
        }

    }


    public void TransporteLabirinto()
    {
        SceneManager.LoadScene("Cubo_Labirinto");
    }

    public void TransportePassagens()
    {
        SceneManager.LoadScene("Passagens");
    }

    public void TranporteMinijogos()
    {
        SceneManager.LoadScene("Minijogos");
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


    //Efeitos Sonoros
    private void OnTriggerEnter(Collider other)
    {
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

