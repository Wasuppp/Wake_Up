using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portais : MonoBehaviour
{
    [SerializeField] Progresso Progresso;

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


    public void Passagens()
    {
        PortalPassDesativado = true;
    }

    public void Labirinto()
    {
        PortalLabDesativado = true;
    }

    public void Minijogos()
    {
        PortalMinDesativado = true;
    }

    public void Update()
    {
        if (PortalPassDesativado == true)
        {
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
