using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escadas2 : MonoBehaviour
{
    Animator EscadasSobem;

    bool SubirAsEscadas = false;

    float Tempo = 0f;
    AudioSource somE;


    private void Start()
    {
        EscadasSobem = GetComponent<Animator>();
        somE= GetComponent<AudioSource>();
    }

    public void SobeEscadas2 (bool SubirEscadas2)
    {
        if (SubirEscadas2 == true)
        {
            EscadasSobem.SetBool("Trigger", true);
            SubirAsEscadas = true;
            som();
        }
    }

    private void Update()
    {
        if (SubirAsEscadas == true)
        {
            Tempo += Time.deltaTime;

            if (Tempo > 2f)
            {
                EscadasSobem.SetBool("Trigger", false);
            }
        }
    }
    void som()
    {
        somE.Play();


    }
}
