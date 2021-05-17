using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao_Ilha : MonoBehaviour
{
    [SerializeField] LayerMask ImagemInteracao = 8;

    [SerializeField] GameObject Ilha;
    [SerializeField] GameObject ObjetoRotacao;
    [SerializeField] float velocidadeRot = 20f;
    [SerializeField] bool RotacaoPositiva = true;

    bool EmRotacao = false;

    float graus = 0f;

    private Rigidbody Rb;

    private float contadorPositivo = 90f;
    private float contadorNegativo = -90f;

    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 2, ImagemInteracao))
        {
            if (Input.GetKeyDown(KeyCode.E) && EmRotacao == false)
            {
                EmRotacao = true;
            }
        }


        if (EmRotacao == true && RotacaoPositiva ==true)
        {
            Ilha.transform.RotateAround(ObjetoRotacao.transform.position, new Vector3(0, 1, 0), velocidadeRot * Time.deltaTime);

            if (Ilha.transform.eulerAngles.y >= contadorPositivo)
            {
                EmRotacao = false;
                contadorPositivo += 90f;
            }
        }
        else if (EmRotacao == true && RotacaoPositiva == false)
        {
            Ilha.transform.RotateAround(ObjetoRotacao.transform.position, new Vector3(0, 1, 0), velocidadeRot * Time.deltaTime);
            Debug.Log(Ilha.transform.eulerAngles.y);

            if (Ilha.transform.eulerAngles.y <= contadorNegativo)
            {
                EmRotacao = false;
                contadorNegativo -= 90f;
            }
        }     

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.parent = transform;
        }
    }
}
