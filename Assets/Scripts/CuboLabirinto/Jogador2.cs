using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador2 : MonoBehaviour
{

   // [SerializeField] AudioSource cuborodar;

   // bool Trigger1acaba = false;


    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        /* if ((other.gameObject.CompareTag("TriggerRampa1")) && (Trigger1acaba == false))
         {
             Debug.Log("Cuboroda");
             gameObject.GetComponent<AudioSource>().Play();
             Trigger1acaba = true;
         } */

        if (other.CompareTag("objetocolectavel1"))
        {

            other.GetComponent<AudioSource>().Play();
        }
        else if (other.CompareTag("Pista1"))
        {

            other.GetComponent<AudioSource>().Play();
        }
        if (other.CompareTag("rotacao"))
        {

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
        if (other.CompareTag("rotacao"))
        {

            other.GetComponent<AudioSource>().Stop();
        }
    }
}
