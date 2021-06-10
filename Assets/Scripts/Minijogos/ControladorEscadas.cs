using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorEscadas : MonoBehaviour
{
    [SerializeField] GameObject PlataformaEscadas;
    Animator AnimacaoEscadas;

    bool EntramEscadas = false;
    float Tempo = 0f;

    private void Start()
    {
        AnimacaoEscadas= GetComponent<Animator>();
    }

    public void AnimarEscadas()
    {
        AnimacaoEscadas.SetBool("Trigger", true);
        EntramEscadas = true;
    }

    private void Update()
    {
        if (EntramEscadas == true)
        {
            Tempo += Time.deltaTime;

            if (Tempo > 2f)
            {
                AnimacaoEscadas.SetBool("Trigger", false);
                EntramEscadas = false;
            }
        }
    }
}
