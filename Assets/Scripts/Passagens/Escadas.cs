using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escadas : MonoBehaviour
{
    Animator EscadasSobem;

    bool SubirAsEscadas = false;

    float Tempo = 0f;

    private void Start()
    {
        EscadasSobem = GetComponent<Animator>();
    }

    public void SobeEscadas(bool SubirEscadas)
    {
        if (SubirEscadas == true)
        {
            EscadasSobem.SetBool("Trigger", true);
            SubirAsEscadas = true;
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
}
