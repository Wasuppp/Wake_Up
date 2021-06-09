using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalLabirinto : MonoBehaviour
{

    [SerializeField] PersistentManagerScript PersistentManagerScript;
    [SerializeField] float TempoEsperaTransporte = 2f;

    float Tempo = 0f;

    bool DentroPortalLab = false;
    bool BloquearNivelLabirinto = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DentroPortalLab = true;
            BloquearNivelLabirinto = true;
            PersistentManagerScript.InstanciaUrso();
        }
    }

    private void Update()
    {
        if (DentroPortalLab == true)
        {
            Tempo += Time.deltaTime;

            if (Tempo >= TempoEsperaTransporte) // se o jogador estiver dentro do portal mais de 2 segundos, é teletransportado para o nivel
            {
                SceneManager.LoadScene("Cubo_Labirinto");
                DentroPortalLab = false;
            }
        }
    }
}
