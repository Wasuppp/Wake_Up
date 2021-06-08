using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalPassagens : MonoBehaviour
{
    [SerializeField] GameObject PortalPass;

    bool PortalDesativado = false;
    bool Constante = false;

    // Update is called once per frame
    void Update()
    {
        if (PortalDesativado == true && Constante == false)
        {
            Constante = true;
            PortalPass.GetComponent<Collider>().isTrigger = false;
            Debug.Log("Destoi Portal");
        }
    }

    public void VerificaProgressoPass()
    {
        PortalDesativado = true;
        Update();
    }
}
