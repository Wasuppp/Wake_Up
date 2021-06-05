using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao : MonoBehaviour
{
    [SerializeField] Escadas Escadas;

    //Animation Escadas;
    Animator BotaoCarrega;

    bool BotaoPressionado = false;

    bool SubirEscadas = false;


    private void Start()
    {
        BotaoCarrega = GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag ("Player") && BotaoPressionado == false)
        {
            BotaoPressionado = true;
        }        
    }

    private void Update()
    {
        if (BotaoPressionado == true)
        {
            BotaoCarrega.SetBool("Trigger (bool)", true);
            SubirEscadas = true;

            Escadas.SobeEscadas(SubirEscadas);
        }
    }
}
