using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao1 : MonoBehaviour
{
    [SerializeField] GameObject Cubo;
    [SerializeField] GameObject ObjetoRotacao;


    [SerializeField] float velocidadeRot = -20f;

    bool Roda = false;
    bool NaoRodaMais = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Roda = true;
        }
    }

    private void Update()
    {
        if (Roda == true && NaoRodaMais == false)
        {

            Cubo.transform.RotateAround(ObjetoRotacao.transform.position, new Vector3(0, 0, 1), velocidadeRot * Time.deltaTime);
            Debug.Log("" + Cubo.transform.eulerAngles.z);

            if (Cubo.transform.eulerAngles.z <= 270f)
            {
                Roda = false;
                NaoRodaMais = true;
            }
        }
    }

}
