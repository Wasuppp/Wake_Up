using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colectavel : MonoBehaviour
{
    [SerializeField] float TempoTransporte = 2;
    
    float Tempo = 0f;
    bool Transporte = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Transporte = true;
        }
    }
    void Update()
    {
        transform.Rotate(new Vector3(15, 45, 30) * Time.deltaTime);

        if (Transporte == true)
        {
            Tempo += Time.deltaTime;

            if (Tempo > TempoTransporte)
            {
                MudarCena();
            }
        }
    }

    public void MudarCena()
    {
        SceneManager.LoadScene("Sala_Principal");
    }

}
