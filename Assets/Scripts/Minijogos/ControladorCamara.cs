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

    [SerializeField] GameObject codigo1;
    [SerializeField] GameObject codigo2;

    [SerializeField] ControladorEscadas ControladorEscadas;
    [SerializeField] Plataforma Plataforma;

    bool MudarCamara1 = false;
    bool MudarCamara2 = false;
    bool MudarCamara3 = false;

    bool AcabaJogo1 = false;
    bool AcabaJogo2 = false;
    bool AcabaJogo3 = false;

    void  Start()
    {
        codigo1.SetActive(false);
        codigo2.SetActive(false);

        CamaraJogador.enabled = true;  // a cena inicia com a camara do jogador ativada
        camara1.enabled = false;
        camara2.enabled = false;
        camara3.enabled = false;
        CamaraParent3.SetActive(false);
        CamaraParent1.SetActive(false);
        CamaraParent2.SetActive(false);

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

            MudarCamara3 = false;

        }

        if (AcabaJogo1==true && AcabaJogo2==true && AcabaJogo3 == true)
        {
            AcabaJogo1 = false;
            ControladorEscadas.AnimarEscadas();
            Plataforma.AnimarPlataforma();
            codigo1.SetActive(true);
            codigo2.SetActive(true);

        }
    }

    public void Desativa1() // o jogador terminou um dos jogos e volta à camara do player
    {
        AcabaJogo1 = true;

        Jogador.SetActive(true);
        CamaraJogador.enabled = true;

        CamaraParent3.SetActive(false);
        CamaraParent1.SetActive(false);
        CamaraParent2.SetActive(false);
    }

    public void Desativa2() // o jogador terminou um dos jogos e volta à camara do player
    {
        AcabaJogo2 = true;

        Jogador.SetActive(true);
        CamaraJogador.enabled = true;

        CamaraParent3.SetActive(false);
        CamaraParent1.SetActive(false);
        CamaraParent2.SetActive(false);
    }

    public void Desativa3() // o jogador terminou um dos jogos e volta à camara do player
    {
        AcabaJogo3 = true;

        Jogador.SetActive(true);
        CamaraJogador.enabled = true;

        CamaraParent3.SetActive(false);
        CamaraParent1.SetActive(false);
        CamaraParent2.SetActive(false);
    }

}
