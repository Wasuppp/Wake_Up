using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour
{

    private float Tempo = 0f;

    [SerializeField] float TempoEsperaTransporte = 2f;

    private bool DentroPortalLab = false; // O jogador está dentro do portal
    private bool DentroPortalPass = false;
    private bool DentroPortalMin = false;


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "TriggerLab")
        {
            DentroPortalLab = true;
            Debug.Log("Portal_Labirinto");
        }

        if (other.tag == "TriggerPass")
        {
            DentroPortalLab = true;
            Debug.Log("Portal_Passagens");
        }

        if (other.tag == "TriggerMin")
        {
            DentroPortalLab = true;
            Debug.Log("Portal_MiniJogos");
        }

    }


    private void Update()
    {
        if (DentroPortalLab == true)
        {
            Tempo += Time.deltaTime;

            if(Tempo >= TempoEsperaTransporte) // se o jogador estiver dentro do portal mais de 2 segundos, é teletransportado para o nivel
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
                TransportePassagens();
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
}

