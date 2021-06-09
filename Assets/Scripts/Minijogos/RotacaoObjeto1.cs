﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoObjeto1 : MonoBehaviour
{
    [SerializeField] Camera jogador;

    [SerializeField] Camera camara1;

    bool Xcorreto = false;
    bool Ycorreto = false;
    bool Zcorreto = false;

    [SerializeField] GameObject ObjetoImpossivel;

    float VelocidadeRotacao = 20f;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate((Input.GetAxis("Mouse X") * VelocidadeRotacao * Time.deltaTime),
            (Input.GetAxis("Mouse Y") * VelocidadeRotacao * Time.deltaTime), 0, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            camara1.enabled = !camara1.enabled;
            jogador.enabled = !jogador.enabled;
        }
    }
}