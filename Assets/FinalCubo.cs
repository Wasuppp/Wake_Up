using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalCubo : MonoBehaviour
{
    bool triggerAtivado = false;
    float tempo = 0f;
    bool contarTempo = false;
    bool mudarCena = false;
    [SerializeField] float Tempotranporte;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(contarTempo== true)
        {

            tempo += Time.deltaTime;
            if(tempo>= Tempotranporte)
            {

                mudarCena = true;
            }
        }






    }
    public void triggercena()
    {
        triggerAtivado = true;



    }
    private void OnTriggerEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && triggerAtivado == true)
        {
            contarTempo = true;
            if(mudarCena== true)
            {

                SceneManager.LoadScene("CutsceneFinal");
            }

        }



    }

   
}
