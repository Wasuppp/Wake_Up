using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaperCena : MonoBehaviour
{
    float tempo = 0f;
    [SerializeField] float tempoespera = 41f;
    bool espera = false;

    void Start()
    {
        espera = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (espera == true)
        {
            tempo += Time.deltaTime;
            if (tempo >= tempoespera)
            {

                SceneManager.LoadScene("Sala_Principal");
            }

        }
    }
}
