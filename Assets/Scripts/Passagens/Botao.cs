using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao : MonoBehaviour
{
    Animation CarregaBotao;

    [SerializeField] GameObject Escadas;
    [SerializeField] GameObject ObjetoRotacao;
    [SerializeField] float velocidadeRot;

    float Contador;

    bool BotaoPressionado = false;

    private void Start()
    {
        CarregaBotao = gameObject.GetComponent<Animation>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Debug.Log("Botao");             
            CarregaBotao.Play("baixo");
            BotaoPressionado = true;
 
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Debug.Log("Botao");
            CarregaBotao.Play("baixo");
        }

    }

    void RodarEscadas()
    {
        if (BotaoPressionado == true)
        {

            Escadas.transform.RotateAround(ObjetoRotacao.transform.position, new Vector3(0, 1, 0), velocidadeRot * Time.deltaTime); //A sala roda à volta do objeto de rotação, pelo eixo y, a uma velocidade constante

            if (Escadas.transform.eulerAngles.y >= Contador) // se o valor da rotação em y for maior que o valor do contador, a rotação pára
            {
                BotaoPressionado = false;
            }
        }
    }

}
