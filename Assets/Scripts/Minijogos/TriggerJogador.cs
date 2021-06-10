using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerJogador : MonoBehaviour
{
    [SerializeField] ControladorCamara ControladorCamara;

    [SerializeField] Camera camara1;
    [SerializeField] Camera camara2;

    [SerializeField] RotacaoObjeto1 RotacaoObjeto1;
    [SerializeField] RotacaoObjeto2 RotacaoObjeto2;

    public bool Camara1 = false;
    public bool Camara2 = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Rotacao1") && Input.GetKeyDown(KeyCode.E) && Camara1 == false)
        {
            // o jogador entra no trigger do objeto 1 (triangulo impossivel)

            Camara1 = true; 
            ControladorCamara.AtivaObjeto1(); // transporta o estado da camara 1 para o controlador de camara
            RotacaoObjeto1.AtivaScript1(); // o script de rotacao do objeto 1 é ativado
        }        
        
        if (other.CompareTag("Rotacao2") && Input.GetKeyDown(KeyCode.E) && Camara2 == false)
        {
            // o jogador entra no trigger do objeto 2 (cubo impossivel)

            Camara2 = true;
            ControladorCamara.AtivaObjeto2(); // transporta o estado da camara 2 para o controlador de camara
            RotacaoObjeto2.AtivaScript2(); // o script de rotação do objeto 2 é ativado    
        }
    }
}
