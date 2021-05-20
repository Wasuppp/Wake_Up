using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    Vector3 PosCheckPoint0;
    Quaternion OrientCheckPoint0;

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
        PosCheckPoint0 = transform.position;
        OrientCheckPoint0 = transform.rotation;

        LocalDeCheckpoint = PosCheckPoint0;
        OrientacaoDeChekpoint = OrientCheckPoint0;      

    }

    private void Update()
    {
        CheckPoint1.transform.position = CheckPoint1.transform.position;

        CheckPoint2.transform.position = CheckPoint2.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("CheckPoint1"))
        {
            LocalDeCheckpoint = CheckPoint1.transform.position;
            OrientCheckPoint0 = CheckPoint1.transform.rotation;
            Debug.Log("checkpoint sala1");

        } else if (other.gameObject.tag == ("CheckPoint2"))
        {
            LocalDeCheckpoint = CheckPoint2.transform.position;
            OrientCheckPoint0 = CheckPoint2.transform.rotation;
            Debug.Log("checkpoint sala2");

        }
        else if (other.gameObject.tag == ("CheckPoint3"))
        {
            LocalDeCheckpoint = CheckPoint3.transform.position;
            OrientCheckPoint0 = CheckPoint3.transform.rotation;
        }

        if (other.gameObject.tag==("Respawn"))
        {
            transform.position = LocalDeCheckpoint;
            transform.rotation = OrientacaoDeChekpoint;
        }
    }


}
