using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCodigo : MonoBehaviour
{
    
    [SerializeField] int NumeroCerto1;
    [SerializeField] int NumeroCerto2;

    [SerializeField] Combinacao1 Combinacao1;
    [SerializeField] Combinacao2 Combinacao2;

    [SerializeField] Porta Porta;

    bool AbrirPorta = false;

    bool Codigo1Certo = false;
    bool Codigo2Certo = false;

    public void NumeroCodigo1(int NumeroRotacao1)
    {
        if (NumeroRotacao1 == NumeroCerto1)
        {
            Codigo1Certo = true;
            Debug.Log("Numero 1 certo");
            Combinacao1.DesativaCodigo1();
        }
        else
        {
            Codigo1Certo = false;
        }
    }

    public void NumeroCodigo2(int NumeroRotacao2)
    {
        if (NumeroRotacao2 == NumeroCerto2)
        {
            Codigo2Certo = true;
            Debug.Log("Numero 2 certo");
            Combinacao2.DesativaCodigo2();
        }
        else
        {
            Codigo2Certo = false;
        }
    }

    private void Update()
    {
        if (Codigo1Certo == true && Codigo2Certo == true)
        {
            Debug.Log("AbrirPorta");

            Porta.AnimacaoPorta();
        }
    }
}
