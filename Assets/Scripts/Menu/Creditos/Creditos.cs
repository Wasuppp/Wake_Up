using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    float Tempo = 0f;
    bool VoltarMenu = false;

    [SerializeField] float Delay = 2f;

    public void Menu()
    {
        VoltarMenu = true;
    }

    public void Update()
    {
        if (VoltarMenu == true)
        {
            Tempo += Time.deltaTime;

            if (Tempo >= Delay)
            {
                VoltarParaMenu();
                VoltarMenu = false;
            }
        }
    }

    public void VoltarParaMenu()
    {
        SceneManager.LoadScene("Main menu");
    }

}
