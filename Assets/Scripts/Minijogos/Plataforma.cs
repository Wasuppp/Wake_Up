using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    [SerializeField] GameObject plataforma;
    Animator AnimacaoPlataforma;
    AudioSource escadassom;

    bool EntramEscadas = false;
    float Tempo = 0f;

    bool Animarplataforma = false;

    private void Start()
    {
        AnimacaoPlataforma = GetComponent<Animator>();
        escadassom = GetComponent<AudioSource>();
    }

    public void AnimarPlataforma()
    {
        AnimacaoPlataforma.SetBool("Ativar", true);
        Animarplataforma = true;
        escadasSom();
    }

    private void Update()
    {
        if (Animarplataforma == true)
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
        escadassom.Play();
    }
}
