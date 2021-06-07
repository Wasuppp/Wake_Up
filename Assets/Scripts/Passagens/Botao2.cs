using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botao2 : MonoBehaviour
{
    [SerializeField] Escadas2 Escadas2;

    //Animation Escadas;
    Animator Botao2Carrega;

    bool Botao2Pressionado = false;

    bool SubirEscadas2 = false;

    AudioSource Sombotao;


    private void Start()
    {
        Botao2Carrega = GetComponent<Animator>();
        Sombotao= GetComponent<AudioSource>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag ("Player") && Botao2Pressionado == false)
        {
            Botao2Pressionado = true;
            sombotao();
        }        
    }

    private void Update()
    {
        if (Botao2Pressionado == true)
        {
            Botao2Carrega.SetBool("Trigger (bool)", true);
            SubirEscadas2 = true;

            Escadas2.SobeEscadas2(SubirEscadas2);
        }
    }
    void sombotao()
    {
        Sombotao.Play();
        Debug.Log("sombotao");

    }
}
