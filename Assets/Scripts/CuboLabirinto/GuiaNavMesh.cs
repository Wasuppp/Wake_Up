using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuiaNavMesh : MonoBehaviour
{
    NavMeshAgent agente;
    [SerializeField] Transform alvo;

    bool PodeAndar = false;

    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PodeAndar == true)
        {
            agente.destination = alvo.position;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            PodeAndar = true;
        }
    }
}
