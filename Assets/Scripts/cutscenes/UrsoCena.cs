using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UrsoCena : MonoBehaviour
{
    float tempo = 0f;
    [SerializeField] float tempoespera = 64f;
    bool espera = false;
    
    // Start is called before the first frame update
    void Start()
    {
        espera = true;


    }

    // Update is called once per frame
    void Update()
    {
        if(espera== true)
        {
            tempo += Time.deltaTime;
            if(tempo >= tempoespera || Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Sala_Principal");
                espera = false;
            }

        }




    }
}
