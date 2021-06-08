using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RotacaoObjeto : MonoBehaviour
{
    float VelocidadeRotacao = 20f;

    CinemachineVirtualCamera currentCamera;

    [SerializeField]
    CinemachineVirtualCamera target;

    private void Update()
    {
        transform.Rotate((Input.GetAxis("Mouse X") * VelocidadeRotacao * Time.deltaTime),
         (Input.GetAxis("Mouse Y") * VelocidadeRotacao * Time.deltaTime), 0, Space.World);

        if (Input.GetKeyDown(KeyCode.E))
        {
            currentCamera.Priority--;

            currentCamera = target;

            currentCamera.Priority++;
        }

    }
}
