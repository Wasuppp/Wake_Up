using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador2 : MonoBehaviour
{

    // [SerializeField] AudioSource cuborodar;

    // bool Trigger1acaba = false;



    bool Musica1Acaba = false;
    bool Musica2Acaba = false;
    bool Musica3Acaba = false;

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("objetocolectavel1"))
        {

            other.GetComponent<AudioSource>().Play();
        }
        else if (other.CompareTag("Pista1"))
        {

            other.GetComponent<AudioSource>().Play();
        }
        if (other.CompareTag("Rotacao1") && Musica1Acaba==false)
        {
            Musica1Acaba = true;
            other.GetComponent<AudioSource>().Play();
        }
        else if (other.CompareTag("Rotacao2") && Musica2Acaba==false)
        {
            Musica2Acaba = true;
            other.GetComponent<AudioSource>().Play();
        }
        else if (other.CompareTag("Rotacao3") && Musica3Acaba==false)
        {
            Musica3Acaba = true;
            other.GetComponent<AudioSource>().Play();
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("objetocolectavel1"))
        {

            other.GetComponent<AudioSource>().Stop();
        }

        else if (other.CompareTag("Pista1"))
        {

            other.GetComponent<AudioSource>().Stop();
        }
        if (other.CompareTag("Rotacao1")|| other.CompareTag("Rotacao2")|| other.CompareTag("Rotacao3"))
        {

            other.GetComponent<AudioSource>().Stop();
        }
    }
}
