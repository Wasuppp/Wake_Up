using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalPassagens : MonoBehaviour
{
    [SerializeField] PersistentManagerScript PersistentManagerScript;
    [SerializeField] float TempoEsperaTransporte = 2f;

    float Tempo = 0f;

    bool DentroPortalPass = false;
    bool BloquearNivelPassagens = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DentroPortalPass = true;
            BloquearNivelPassagens = true;
            PersistentManagerScript.InstanciaPapeis();
        }
    }

    private void Update()
    {
        if (DentroPortalPass == true)
        {
            Tempo += Time.deltaTime;

            if (Tempo >= TempoEsperaTransporte) // se o jogador estiver dentro do portal mais de 2 segundos, é teletransportado para o nivel
            {
                SceneManager.LoadScene("Passagens");
                DentroPortalPass = false;
            }
        }
    }
}
