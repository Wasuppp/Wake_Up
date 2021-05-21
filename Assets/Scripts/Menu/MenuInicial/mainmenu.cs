using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    [SerializeField] float Delay = 2f;
    
    float Tempo = 0f;

    bool MudarSalaPrincipal = false;
    bool MudarCreditos = false;
    bool SairJogo = false;

    public void StartGame()
    {
        MudarSalaPrincipal = true; //O jogador pressiona em "Jogar"
    }

    public void AbrirCreditos()
    {
        MudarCreditos = true; // O jogador pressiona em "Creditos"
    }

    public void SairDoJogo()//o jogador pressiona em "sair"
    {
        SairJogo = true;
    }


    public void Update()
    {
        if (MudarSalaPrincipal == true)
        {
            Tempo += Time.deltaTime;
            if (Tempo >= Delay)
            {
                SalaPrincipal();
                MudarSalaPrincipal = false;
            }

        } else if (MudarCreditos == true)
        {
            Tempo += Time.deltaTime;
            if (Tempo >= Delay)
            {
                Creditos();
                MudarCreditos = false;
            }

        } else if (SairJogo == true)
        {
            Tempo += Time.deltaTime;
            if (Tempo >= Delay)
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

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos"); // muda a cena para creditos
    }
    public void ExitGame()
    {
        Application.Quit(); // fecha o jogo
    }
}
