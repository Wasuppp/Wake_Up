using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ligação_Ilhas : MonoBehaviour
{
    bool EntrouemParent = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && EntrouemParent == false)
        {
            other.transform.parent = transform; //Jogador passa para filho da sala 
            EntrouemParent = true;
        }
    }
}
