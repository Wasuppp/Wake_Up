using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoObjeto2 : MonoBehaviour
{
    [SerializeField] Camera jogador;

    [SerializeField] Camera camara2;
    [SerializeField] float TempoEspera;
    float Tempo = 0f;
    bool RotacaoCerta = false;

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
            if (Input.GetMouseButton(0) && RotacaoCerta == false)
            {
                ObjetoImpossivel.transform.Rotate(0, (Input.GetAxis("Mouse X") * VelocidadeRotacao * Time.deltaTime), 0, Space.World);
            }

            //-0,4899118     

            if ((ObjetoImpossivel.transform.localRotation.y > 0.485f && ObjetoImpossivel.transform.localRotation.y < 0.50f) ||
            (ObjetoImpossivel.transform.localRotation.y < -0.485f && ObjetoImpossivel.transform.localRotation.y > -0.50f))

            {
                RotacaoCerta = true;
                Tempo += Time.deltaTime;

                if (Tempo > TempoEspera)
                {
                    ControladorCamara.Desativa();
                    this.enabled = false;
                    RotacaoCerta = false;
                }
            }
        }

    }
}
