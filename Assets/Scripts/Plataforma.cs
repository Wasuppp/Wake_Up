using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Plataforma : MonoBehaviour
{

    [SerializeField] GameObject jogador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject == jogador){
            Debug.Log("teste");
         //   jogador.GetComponent<FirstPersonController>().enabled = false;
            jogador.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject == jogador){
            jogador.transform.parent = null;
            jogador.GetComponent<FirstPersonController>().enabled = true;
        }
    }
}
