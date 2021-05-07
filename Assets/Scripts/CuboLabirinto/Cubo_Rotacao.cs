using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_Rotacao : MonoBehaviour
{
    [SerializeField] GameObject Cubo;
    [SerializeField] GameObject ObjetoRotacao1;
    [SerializeField] GameObject ObjetoRotacao2;
    [SerializeField] GameObject ObjetoRotacao3;
    [SerializeField] float speed = 20f; //velocidade de rotacao

    bool AcabaRotacao1 = false;
    bool AcabaRotacao2 = false;
    bool AcabaRotacao3 = false;

    float RotacaoInicialZ = 0f;
    bool ValorRotacaoInicial = false;

    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "TriggerRampa1")
        {
            Rotacao1();

        }
        else if (other.tag == "TriggerRampa2")
        {
            Rotacao2();

        }
        else if (other.tag == "TriggerRampa3")
        {
            Rotacao3();
        }
    }

    void Rotacao1()
    {
        Vector3 RotacaoEixoX = new Vector3(0, 0, 1);

        if (AcabaRotacao1 == false)
        {
            if (ValorRotacaoInicial == true)
            {
                RotacaoInicialZ = Cubo.transform.eulerAngles.z;
                ValorRotacaoInicial = false;
            }

            Cubo.transform.RotateAround(ObjetoRotacao1.transform.position, RotacaoEixoX, speed * Time.deltaTime);

            if (Cubo.transform.eulerAngles.z >= (RotacaoInicialZ + 90f))
            {
                AcabaRotacao1 = true;
            }
        }
    }

    void Rotacao2()
    {
        Vector3 RotacaoEixoZ = new Vector3(0, 0, 1);

        if (AcabaRotacao2 == false)
        {
            if (ValorRotacaoInicial == true)
            {
                RotacaoInicialZ = Cubo.transform.eulerAngles.z;
                ValorRotacaoInicial = false;
            }

            Cubo.transform.RotateAround(ObjetoRotacao2.transform.position, RotacaoEixoZ, speed * Time.deltaTime);

            if (Cubo.transform.eulerAngles.z >= (RotacaoInicialZ + 90f))
            {
                AcabaRotacao2 = true;
            }
        }
    }

    void Rotacao3()
    {
        Vector3 RotacaoEixoZ = new Vector3(0, 0, 1);

        if (AcabaRotacao3 == false)
        {
            if (ValorRotacaoInicial == true)
            {
                RotacaoInicialZ = Cubo.transform.eulerAngles.x;
                ValorRotacaoInicial = false;
            }

            Cubo.transform.RotateAround(ObjetoRotacao3.transform.position, RotacaoEixoZ, speed * Time.deltaTime);

            if (Cubo.transform.eulerAngles.z >= (RotacaoInicialZ + 90f))
            {
                AcabaRotacao3 = true;
            }
        }
    }
}
