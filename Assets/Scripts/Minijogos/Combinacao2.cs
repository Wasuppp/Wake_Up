using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combinacao2 : MonoBehaviour
{
    [SerializeField] LayerMask ImagemInteracao = 8;
    [SerializeField] GameObject Roda2;
    [SerializeField] GameObject ObjetoRotacao;
    [SerializeField] float velocidadeRot;
    bool EmRotacao = false;

    [SerializeField] ControladorCodigo ControladorCodigo;

    bool desativa2 = false;

    float Contador = 60f;
    int NumeroRotacao2 = 1;

    bool Reset = false;

    public void DesativaCodigo2()
    {
        desativa2 = true;
    }

    private void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 20, ImagemInteracao)) // Se a direção da camara do jogador estiver sobre o objeto-escala
        {
            if (Input.GetKeyDown(KeyCode.E) && EmRotacao == false && desativa2 == false) //se o jogador pressionar a tecla "E" e a sala estiver parada
            {
                EmRotacao = true; // a sala roda
                ControladorCodigo.NumeroCodigo2(NumeroRotacao2);
            }
        }

        if (EmRotacao == true)
        {
            Roda2.transform.RotateAround(ObjetoRotacao.transform.position, new Vector3(0, 1, 0), velocidadeRot * Time.deltaTime);

            if (Roda2.transform.eulerAngles.y >= Contador && Reset == false)
            {
                if (NumeroRotacao2 >= 5)
                {
                    NumeroRotacao2 = 6;
                    Reset = true;               
                }
                else
                {
                    Contador += 60f;
                    NumeroRotacao2 += 1;
                }
                
                EmRotacao = false;
            }

            if (Roda2.transform.eulerAngles.y <= 0.5f && Reset == true)
            {
                NumeroRotacao2 = 1;
                Contador = 60f;
                EmRotacao = false;
                Reset = false;
            }
        }
    }
}
