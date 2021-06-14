using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    bool MudarMenu = false;
    bool SairJogo = false;

    float Tempo = 0f;
    [SerializeField] float DelayMenu = 0f;
    [SerializeField] float DelaySair = 0f;

    public void AbrirMenuInicial()
    {
        MudarMenu = true;
    }

    public void SairdoJogo()
    {
        SairJogo = true;
    }

    private void Update()
    {
        if (MudarMenu == true)
        {
            DelayMenu = 0f;
            Tempo += Time.deltaTime;
            if (Tempo >= DelayMenu)
            {
                MudarMenu = false;
                SceneManager.LoadScene("Main Menu");
            }
        }
        
        if (SairJogo == true)
        {
            DelaySair = 0f;
            Tempo += Time.deltaTime;
            if (Tempo >= DelaySair)
            {
                SairJogo = false;
                Application.Quit();
            }
        }
    }
}
