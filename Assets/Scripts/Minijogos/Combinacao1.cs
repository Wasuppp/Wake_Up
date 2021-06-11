using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combinacao1 : MonoBehaviour
{
    [SerializeField] LayerMask ImagemInteracao = 8;
    [SerializeField] GameObject Roda1;
    [SerializeField] GameObject ObjetoRotacao;
    [SerializeField] float velocidadeRot;

    [SerializeField] ControladorCodigo ControladorCodigo;

    bool EmRotacao = false;

    float Contador = 60f;
    int NumeroRotacao1 = 1;

    bool Reset = false;

    private void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 20, ImagemInteracao)) // Se a direção da camara do jogador estiver sobre o objeto-escala
        {
            if (Input.GetKeyDown(KeyCode.E) && EmRotacao == false) //se o jogador pressionar a tecla "E" e a sala estiver parada
            {
                EmRotacao = true; // a sala roda
                ControladorCodigo.NumeroCodigo1(NumeroRotacao1);

            }
        }

        if (EmRotacao == true)
        {
            Roda1.transform.RotateAround(ObjetoRotacao.transform.position, new Vector3(0, 1, 0), velocidadeRot * Time.deltaTime);

            if (Roda1.transform.eulerAngles.y >= Contador && Reset == false)
            {
                if (NumeroRotacao1 >= 5)
                {
                    NumeroRotacao1 = 6;
                    Reset = true;               
                }
                else
                {
                    Contador += 60f;
                    NumeroRotacao1 += 1;
                }
                
                EmRotacao = false;
            }

            if (Roda1.transform.eulerAngles.y <= 0.5f && Reset == true)
            {
                NumeroRotacao1 = 1;
                Contador = 60f;
                EmRotacao = false;
                Reset = false;
            }
        }
    }
}
