using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalMinijogos : MonoBehaviour
{

    [SerializeField] PersistentManagerScript PersistentManagerScript;
    [SerializeField] float TempoEsperaTransporte = 2f;

    float Tempo = 0f;

    bool DentroPortalMin = false;
    bool BloquearNivelLabirinto = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DentroPortalMin= true;
            BloquearNivelLabirinto = true;
            PersistentManagerScript.InstanciaPapeis();
        }
    }

    private void Update()
    {
        if (DentroPortalMin == true)
        {
            Tempo += Time.deltaTime;

            if (Tempo >= TempoEsperaTransporte) // se o jogador estiver dentro do portal mais de 2 segundos, é teletransportado para o nivel
            {
                SceneManager.LoadScene("Passagens");
                DentroPortalMin = false;
            }
        }
    }
}
