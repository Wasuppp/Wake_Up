using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoObjeto3 : MonoBehaviour
{
    [SerializeField] Camera jogador;

    [SerializeField] Camera camara3;
    [SerializeField] float TempoEspera;

    float Tempo = 0f;
    bool RotacaoCerta3 = false;

    [SerializeField] GameObject ObjetoImpossivel;

    [SerializeField] float VelocidadeRotacao = 20f;

    bool Objeto3Ativado = false;

    [SerializeField] ControladorCamara ControladorCamara;
     
    public void AtivaScript3()
    {
        Objeto3Ativado = true;
    }

    private void Update()
    {
        if (Objeto3Ativado == true)
        {
            if (Input.GetMouseButton(0) && RotacaoCerta3 == false)
            {
                ObjetoImpossivel.transform.Rotate(0, (Input.GetAxis("Mouse X") * VelocidadeRotacao * Time.deltaTime), 0, Space.World);
            }

            //-0,9383985   

            if ((ObjetoImpossivel.transform.localRotation.y > 0.92f && ObjetoImpossivel.transform.localRotation.y < 0.945f) ||
            (ObjetoImpossivel.transform.localRotation.y < -0.92f && ObjetoImpossivel.transform.localRotation.y > -0.945f))
            {
                RotacaoCerta3 = true;
                Tempo += Time.deltaTime;

                if (Tempo > TempoEspera)
                {
                    ControladorCamara.Desativa();
                    this.enabled = false;
                    RotacaoCerta3 = false;                    
                }
            }
        }
    }
}
