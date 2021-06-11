using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    Animator AnimacaoPlataforma;
    AudioSource PortaSom;

    float Tempo = 0f;

    bool AnimarPorta = false;

    private void Start()
    {
        AnimacaoPlataforma = GetComponent<Animator>();
        PortaSom = GetComponent<AudioSource>();
    }

    public void AnimacaoPorta()
    {
        AnimacaoPlataforma.SetBool("Ativar", true);
        AnimarPorta = true;
        escadasSom();
    }

    private void Update()
    {
        if (AnimarPorta == true)
        {
            Tempo += Time.deltaTime;

            if (Tempo > 2f)
            {
                AnimacaoPlataforma.SetBool("Ativar", false);

            }
        }
    }

    void escadasSom()
    {
        PortaSom.Play();
    }
}
