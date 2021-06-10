using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoObjeto2 : MonoBehaviour
{
    [SerializeField] Camera jogador;

    [SerializeField] Camera camara2;
    [SerializeField] float TempoEspera;
    float Tempo = 0f;
    bool RotacaoCerta2 = false;

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
            if (Input.GetMouseButton(0) && RotacaoCerta2 == false)
            {
                ObjetoImpossivel.transform.Rotate(0, (Input.GetAxis("Mouse X") * VelocidadeRotacao * Time.deltaTime), 0, Space.World);
            }

            // 58,75087
            if ((ObjetoImpossivel.transform.eulerAngles.y > 58.5f && ObjetoImpossivel.transform.eulerAngles.y < 58.95f))

            {
                RotacaoCerta2 = true;
                Tempo += Time.deltaTime;

                if (Tempo > TempoEspera)
                {
                    ControladorCamara.Desativa2();
                    this.enabled = false;
                    RotacaoCerta2 = false;
                }
            }
        }

    }
}
