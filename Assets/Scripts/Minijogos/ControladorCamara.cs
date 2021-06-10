using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    [SerializeField] GameObject Jogador;
    [SerializeField] Camera CamaraJogador;

    [SerializeField] Camera camara1;
    [SerializeField] GameObject objeto1;
    [SerializeField] RotacaoObjeto1 RotacaoObjeto1;
    [SerializeField] GameObject CamaraParent1;

    [SerializeField] Camera camara2;
    [SerializeField] GameObject objeto2;
    [SerializeField] RotacaoObjeto2 RotacaoObjeto2;
    [SerializeField] GameObject CamaraParent2;

    [SerializeField] Camera camara3;
    [SerializeField] GameObject objeto3;
    [SerializeField] RotacaoObjeto3 RotacaoObjeto3;
    [SerializeField] GameObject CamaraParent3;

    bool MudarCamara1 = false;
    bool MudarCamara2 = false;
    bool MudarCamara3 = false;

    void  Start()
    {
        CamaraJogador.enabled = true;  // a cena inicia com a camara do jogador ativada
        camara1.enabled = false;
        camara2.enabled = false;
        camara3.enabled = false;

    }

    public void AtivaObjeto1 ()
    {
        MudarCamara1 = true; // recebe o estado da camara 1 
    }

    public void AtivaObjeto2()
    {
        MudarCamara2 = true; // recebe o estado da camara 2
    }

    public void AtivaObjeto3()
    {
        MudarCamara3 = true;
    }

    private void Update()
    {
        if (MudarCamara1 == true) 
        {
            Jogador.SetActive(false);
            CamaraParent1.SetActive(true);
            CamaraParent2.SetActive(false);
            CamaraParent3.SetActive(false);

            camara1.enabled = true; // a camara 1 é ativada
            CamaraJogador.enabled = false;

            MudarCamara1 = false;

        }

        if (MudarCamara2 == true)
        {
            Jogador.SetActive(false);
            CamaraParent2.SetActive(true);
            CamaraParent1.SetActive(false);
            CamaraParent3.SetActive(false);

            camara2.enabled = true; // a camara 2 é ativada
            CamaraJogador.enabled = false;

            MudarCamara2 = false;

        }

        if (MudarCamara3 == true)
        {
            Jogador.SetActive(false);
            CamaraParent3.SetActive(true);
            CamaraParent1.SetActive(false);
            CamaraParent2.SetActive(false);

            camara3.enabled = true; // a camara 2 é ativada
            CamaraJogador.enabled = false;

            MudarCamara2 = false;

        }
    }

    public void Desativa() // o jogador terminou um dos jogos e volta à camara do player
    {
        CamaraParent3.SetActive(false);
        CamaraParent1.SetActive(false);
        CamaraParent2.SetActive(false);

        Jogador.SetActive(true);
        CamaraJogador.enabled = true;
    }

}
