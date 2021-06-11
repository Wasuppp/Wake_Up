using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class respawn : MonoBehaviour
{
    [SerializeField] GameObject CheckPointTrigger1; //tiggers de checkpoint
    [SerializeField] GameObject CheckPointTrigger2;
    [SerializeField] GameObject CheckPointTrigger3;
    [SerializeField] GameObject CheckPointTrigger4;
    [SerializeField] GameObject CheckPointTrigger5;

    [SerializeField] GameObject CheckPoint1; //tiggers de checkpoint
    [SerializeField] GameObject CheckPoint2;
    [SerializeField] GameObject CheckPoint3;
    [SerializeField] GameObject CheckPoint4;
    [SerializeField] GameObject CheckPoint5;


    Vector3 LocalDeCheckpoint; // variavel que guarda o local de checkpoint a cada instante
    Quaternion OrientacaoDeChekpoint;

    bool RespawnJogador = false;

    void Awake()
    {
        LocalDeCheckpoint = gameObject.transform.position;
        OrientacaoDeChekpoint = gameObject.transform.rotation;      
    }


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
