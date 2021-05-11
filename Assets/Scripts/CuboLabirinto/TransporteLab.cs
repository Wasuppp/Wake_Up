using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransporteLab : MonoBehaviour
{

    private bool DentroPortalLab;

    float Tempo;

    [SerializeField] float TempoEsperaTransporte = 1f;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "TriggerLab")
        {
            DentroPortalLab = true;
        }

    }


    private void Update()
    {
        if (DentroPortalLab == true)
        {
            Tempo += Time.deltaTime;

            if (Tempo >= TempoEsperaTransporte) // se o jogador estiver dentro do portal mais de 2 segundos, é teletransportado para o nivel
            {
                SceneManager.LoadScene("Sala_Principal");
            }
        }
    }

}



