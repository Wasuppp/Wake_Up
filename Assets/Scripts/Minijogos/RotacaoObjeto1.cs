using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoObjeto1 : MonoBehaviour
{
    [SerializeField] Camera jogador;
    [SerializeField] Camera camara1;
    [SerializeField] float TempoEspera;

    float Tempo = 0f;
    bool RotacaoCerta1 = false; 

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
            if (Input.GetMouseButton(0) && RotacaoCerta1 == false)
            {
                ObjetoImpossivel.transform.Rotate(0, (Input.GetAxis("Mouse X") * VelocidadeRotacao * Time.deltaTime), 0, Space.World);
            }

            //Y = 0,8620924
            //Y = 134.5

            if ((ObjetoImpossivel.transform.localRotation.y > 0.861f && ObjetoImpossivel.transform.localRotation.y < 0.863f)||
                (ObjetoImpossivel.transform.localRotation.y < -0.861f && ObjetoImpossivel.transform.localRotation.y > -0.863f))

            {

                RotacaoCerta1 = true;

                Tempo += Time.deltaTime;

                if (Tempo > TempoEspera)
                {
                    ControladorCamara.Desativa();
                    this.enabled = false;
                    RotacaoCerta1 = false;
                }
            }
        }
    }
}
