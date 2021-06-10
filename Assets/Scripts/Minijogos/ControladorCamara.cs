using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour
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
        Debug.Log("Camara Jogador");

        jogador.enabled = true;
        camara1.enabled = false;
        camara2.enabled = false;

        objeto1.GetComponent<RotacaoObjeto1>().enabled = false;
        objeto2.GetComponent<RotacaoObjeto2>().enabled = false;

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Rotacao1") && Input.GetKeyDown(KeyCode.E) && MudarCamara1 == false)
        {
            MudarCamara1 = true;
            jogador.GetComponent<Camera>().enabled = false;
            camara1.GetComponent<Camera>().enabled = true;

            objeto1.GetComponent<RotacaoObjeto1>().enabled = true;
        }

        if (other.CompareTag("Rotacao2") && Input.GetKeyDown(KeyCode.E) && MudarCamara2 == false)
        {
            MudarCamara2 = true;
            jogador.GetComponent<Camera>().enabled = false;
            camara2.GetComponent<Camera>().enabled = true;

            objeto2.GetComponent<RotacaoObjeto2>().enabled = true;
        }
    }
}
