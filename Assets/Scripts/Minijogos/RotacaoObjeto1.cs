using System.Collections;
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

    [SerializeField] float VelocidadeRotacao = 20f;

    [SerializeField] ControladorCamara ControladorCamara;

    bool Objeto1Ativado = false;

    public void AtivaScript1()
    {
        Objeto1Ativado = true;
    }

    private void Update()
    {
        if (Objeto1Ativado == true)
        {
            if (Input.GetMouseButton(0))
            {
                ObjetoImpossivel.transform.Rotate(0, (Input.GetAxis("Mouse X") * VelocidadeRotacao * Time.deltaTime), 0, Space.World);
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                ControladorCamara.Desativa1();
                this.enabled = false;
            }
        }
    }
}
