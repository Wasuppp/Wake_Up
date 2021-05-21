﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void Start()
    {
        LocalDeCheckpoint = transform.position;
        Debug.Log(LocalDeCheckpoint);
        OrientacaoDeChekpoint = transform.rotation;      
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CheckPoint1"))
        {
            LocalDeCheckpoint = CheckPoint1.transform.position;
            OrientacaoDeChekpoint = CheckPoint1.transform.rotation;
            Debug.Log("checkpoint sala1");

        } else if (other.CompareTag("CheckPoint2"))
        {
            LocalDeCheckpoint = CheckPoint2.transform.position;
            OrientacaoDeChekpoint = CheckPoint2.transform.rotation;
            Debug.Log("checkpoint sala2");

        }
        else if (other.CompareTag("CheckPoint3"))
        {
            LocalDeCheckpoint = CheckPoint3.transform.position;
            OrientacaoDeChekpoint = CheckPoint3.transform.rotation;
        }

        if (other.CompareTag("Respawn"))
        {
            Debug.Log("respawn_jogador");
            transform.position = LocalDeCheckpoint;
            Debug.Log(transform.position);

            transform.rotation = OrientacaoDeChekpoint;
        }
    }
}
