using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorEscadas : MonoBehaviour
{
    [SerializeField] GameObject PlataformaEscadas;
    Animator AnimacaoEscadas;
    AudioSource escadassom;

    bool EntramEscadas = false;
    float Tempo = 0f;

    bool Animarescadas = false;

    private void Start()
    {
        AnimacaoEscadas= GetComponent<Animator>();
       escadassom = GetComponent<AudioSource>();
    }

    public void AnimarEscadas()
    {
        AnimacaoEscadas.SetBool("Ativar", true);
        Animarescadas = true;
        escadasSom();
    }

    private void Update()
    {
        if (Animarescadas == true)
        {
            Tempo += Time.deltaTime;

            if (Tempo > 2f)
            {
                AnimacaoEscadas.SetBool("Ativar", false);
                
            }
        }
    }
    void escadasSom()
    {

        escadassom.Play();
    }
}
