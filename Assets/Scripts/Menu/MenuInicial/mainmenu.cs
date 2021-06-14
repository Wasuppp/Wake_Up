using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    [SerializeField] float Delay = 2f;

    float TempoJogador = 0f;
    float TempoCreditos = 0f;
    float TempoSair = 0f;

    bool MudarSalaPrincipal = false;
    bool MudarMenu = false;
    bool SairJogo = false;

    private void Awake()
    {
        TempoJogador = 0f;
        TempoCreditos = 0f;
        TempoSair = 0f;
    }

    public void StartGame()
    {
        MudarSalaPrincipal = true; //O jogador pressiona em "Jogar"
    }

    public void AbrirMenu()
    {
        MudarMenu = true; // O jogador pressiona em "Creditos"
    }

    public void SairDoJogo()//o jogador pressiona em "sair"
    {
        SairJogo = true;
    }


    public void Update()
    {
        if (MudarSalaPrincipal == true)
        {
            TempoJogador += Time.deltaTime;
            if (TempoJogador >= Delay)
            {
                SceneManager.LoadScene("Sala_Principal");
                MudarSalaPrincipal = false;
            }

        } else if (MudarMenu == true)
        {
            TempoCreditos += Time.deltaTime;
            if (TempoCreditos >= Delay)
            {
                SceneManager.LoadScene("Creditos");
                MudarMenu = false;
            }

        } else if (SairJogo == true)
        {
            TempoSair += Time.deltaTime;
            if (TempoSair >= Delay)
            {
                ExitGame();
                SairJogo = false;
            }
        }
    }

    public void SalaPrincipal()
    {
        SceneManager.LoadScene("Sala_Principal"); // muda a cena para a sala principal
    }

    public void MenuCreditos()
    {
        SceneManager.LoadScene("Creditos"); // muda a cena para creditos
    }
    public void ExitGame()
    {
        Application.Quit(); // fecha o jogo
    }
}
