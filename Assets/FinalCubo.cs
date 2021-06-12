using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalCubo : MonoBehaviour
{
    bool ContarTempo = false;
    float tempo = 0f;
    [SerializeField] float Tempotranporte;

    void Update()
    {
        tempo += Time.deltaTime;
        if(tempo>= Tempotranporte)
        {
            SceneManager.LoadScene("CutsceneFinal");              
        }
    }

}
