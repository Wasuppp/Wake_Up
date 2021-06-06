using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoObjeto : MonoBehaviour
{
    float VelocidadeRotacao = 20f;

    private void Update()
    {
        transform.Rotate((Input.GetAxis("Mouse X") * VelocidadeRotacao * Time.deltaTime),
         (Input.GetAxis("Mouse Y") * VelocidadeRotacao * Time.deltaTime), 0, Space.World);
    }
}
