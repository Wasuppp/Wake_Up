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

    [SerializeField] RotacaoObjeto1 RotacaoObjeto1;
    [SerializeField] RotacaoObjeto2 RotacaoObjeto2;

    bool MudarCamara1 = false;
    bool MudarCamara2 = false;

    void  Start()
    {
        jogador.enabled = true;  // a cena inicia com a camara do jogador ativada
        camara1.enabled = false;
        camara2.enabled = false;

        camara1.GetComponent<AudioListener>().enabled = false; // apenas o AudioListener do jogador é ativado
        camara2.GetComponent<AudioListener>().enabled = false;

    }

    public void AtivaObjeto1 (bool Camara1)
    {
        MudarCamara1 = Camara1; // recebe o estado da camara 1 
    }

    public void AtivaObjeto2(bool Camara2)
    {
        MudarCamara2 = Camara2; // recebe o estado da camara 2
    }

    private void Update()
    {
        if (MudarCamara1 == true) 
        {
            camara1.enabled = true; // a camara 1 é ativada
            jogador.enabled = false;
            camara2.enabled = false;

            MudarCamara1 = false; 

        } else if (MudarCamara2 == true)
        {
            camara2.enabled = true; // a camara 2 é ativada
            jogador.enabled = false;
            camara1.enabled = false;

            MudarCamara2 = false;
        }
    }

    public void Desativa() // o jogador terminou um dos jogos e volta à camara do player
    {
        jogador.enabled = true;
        camara1.enabled = false;
        camara2.enabled = false;
    }
}
