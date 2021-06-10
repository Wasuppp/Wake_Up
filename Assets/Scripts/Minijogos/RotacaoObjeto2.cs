using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoObjeto2 : MonoBehaviour
{
    [SerializeField] Camera jogador;

    [SerializeField] Camera camara2;

    bool Xcorreto = false;
    bool Ycorreto = false;
    bool Zcorreto = false;

    [SerializeField] GameObject ObjetoImpossivel;

    [SerializeField] float VelocidadeRotacao = 20f;

    bool Objeto2Ativado = false;

    [SerializeField] ControladorCamara ControladorCamara;
     
    public void AtivaScript2()
    {
        Objeto2Ativado = true;
    }

    private void Update()
    {
        if (Objeto2Ativado == true)
        {
            if (Input.GetMouseButton(0))
            {
                ObjetoImpossivel.transform.Rotate(0, (Input.GetAxis("Mouse X") * VelocidadeRotacao * Time.deltaTime), 0, Space.World);
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                ControladorCamara.Desativa2();
                this.enabled = false;
            }
        }

    }
}
