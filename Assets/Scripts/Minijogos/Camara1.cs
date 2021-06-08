using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara1 : MonoBehaviour
{
    [SerializeField] Camera jogador;

    [SerializeField] Camera camara1;

    [SerializeField] GameObject objeto1;

    bool MudarCamara = false;

    void  Start()
    {
        objeto1.GetComponent<RotacaoObjeto>().enabled = false;
        jogador.enabled = true;
        camara1.enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && MudarCamara == false)
        {
            objeto1.GetComponent<RotacaoObjeto>().enabled = true;
            MudarCamara = true;
            jogador.enabled = !jogador.enabled;
            camara1.enabled = !camara1.enabled;
        }
    }
}
