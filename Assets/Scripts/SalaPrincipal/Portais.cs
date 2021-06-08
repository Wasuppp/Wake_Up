using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portais : MonoBehaviour
{
    [SerializeField] GameObject PortalPass;
    [SerializeField] GameObject PortalMin;
    [SerializeField] GameObject PortalLab;

    [SerializeField] GameObject PortalP;
    [SerializeField] GameObject PortalM;
    [SerializeField] GameObject PortalL;

    [SerializeField] Material PortalDesativado;
    [SerializeField] Material PortalAtivado;


    bool PortalPassDesativado = false;
    bool ConstantePass = false;

    bool PortalMinDesativado = false;
    bool ConstanteMin = false;

    bool PortalLabDesativado = false;
    bool ConstanteLab = false;

    private void Awake()
    {
        ConstantePass = false;
        ConstanteLab = false;
        ConstanteMin = false;
    }
    public void VerificaProgressoPass()
    {
        PortalPassDesativado = true;
        Update();
    }

    public void VerificaProgressoMin()
    {
        PortalMinDesativado = true;
        Update();
    }

    public void VerificaProgressoLab()
    {
        PortalPassDesativado = true;
        Update();
    }

    void Update()
    {
        if (PortalPassDesativado == true && ConstantePass == false)
        {
            ConstantePass = true;
            PortalPass.GetComponent<Collider>().isTrigger = false;
            PortalP.GetComponent<MeshRenderer>().material = PortalDesativado;
        }

        if (PortalLabDesativado == true && ConstanteLab == false)
        {
            ConstanteLab = true;
            PortalLab.GetComponent<Collider>().isTrigger = false;
            PortalL.GetComponent<MeshRenderer>().material = PortalDesativado;
        }

        if (PortalMinDesativado == true && ConstanteMin == false)
        {
            ConstanteMin = true;
            PortalMin.GetComponent<Collider>().isTrigger = false;
            PortalM.GetComponent<MeshRenderer>().material = PortalDesativado;
        }
    }
}
