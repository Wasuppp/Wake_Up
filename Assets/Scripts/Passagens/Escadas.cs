using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escadas : MonoBehaviour
{
    Animator EscadasSobem;

    bool SubirAsEscadas = false;

    float Tempo = 0f;

    AudioSource somE1;

    private void Start()
    {
        EscadasSobem = GetComponent<Animator>();
        somE1 = GetComponent<AudioSource>();
    }

    public void SobeEscadas(bool SubirEscadas)
    {
        if (SubirEscadas == true)
        {
            EscadasSobem.SetBool("Trigger", true);
            SubirAsEscadas = true;
            som2();

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
    void som2()
    {
        somE1.Play();
        Debug.Log("somtocar");
    }
}
