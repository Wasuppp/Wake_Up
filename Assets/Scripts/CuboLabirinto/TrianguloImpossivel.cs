using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrianguloImpossivel : MonoBehaviour
{
    [SerializeField] GameObject Jogador;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Jogador.transform.position);
    }
}
