using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara1 : MonoBehaviour
{
    [SerializeField] Camera jogador;

    [SerializeField] Camera camara1;
    [SerializeField] Camera camara2;

    [SerializeField] GameObject objeto1;
    [SerializeField] GameObject objeto2;

    bool MudarCamara1 = false;
    bool MudarCamara2 = false;
    bool MudarCamara3 = false;

    void  Start()
    {
        objeto1.GetComponent<RotacaoObjeto>().enabled = false;
        jogador.enabled = true;
        camara1.enabled = false;
        camara2.enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Rotacao1"))
        {
            if (Input.GetKeyDown(KeyCode.E) && MudarCamara1 == false)
            {
                objeto1.GetComponent<RotacaoObjeto>().enabled = true;
                MudarCamara1 = true;
                jogador.enabled = !jogador.enabled;
                camara1.enabled = !camara1.enabled;
            }
        }
        if (other.CompareTag("Rotacao2"))
        {
            if (Input.GetKeyDown(KeyCode.E) && MudarCamara2 == false)
            {
                objeto2.GetComponent<RotacaoObjeto>().enabled = true;
                MudarCamara2 = true;
                jogador.enabled = !jogador.enabled;
                camara2.enabled = !camara2.enabled;
            }
        }


    }
}
