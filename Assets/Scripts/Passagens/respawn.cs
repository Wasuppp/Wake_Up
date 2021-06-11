using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class respawn : MonoBehaviour
{

    bool RespawnJogador = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Respawn"))
        {
            RespawnJogador = true;
        }

    }

    private void Update()
    {
        if (RespawnJogador == true)
        {
            SceneManager.LoadScene("Passagens");
        }
    }

}
