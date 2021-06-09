﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentManagerScript : MonoBehaviour
{
    [SerializeField] GameObject PortalPass;
    [SerializeField] GameObject PortalMin;
    [SerializeField] GameObject PortalLab;

    [SerializeField] GameObject PortalP;
    [SerializeField] GameObject PortalM;
    [SerializeField] GameObject PortalL;

    [SerializeField] Material PortalDesativado;
    [SerializeField] Material PortalAtivado;

    [SerializeField] GameObject Urso;
    [SerializeField] GameObject PosUrso;
    [SerializeField] Light Luz2;
    [SerializeField] Transform PosLuz2;

    [SerializeField] GameObject Papeis;
    [SerializeField] GameObject PosPapel;
    [SerializeField] Light Luz1;
    [SerializeField] Transform PosLuz1;

    [SerializeField] GameObject Telemovel;
    [SerializeField] GameObject PosTelemovel;
    [SerializeField] Light Luz3;
    [SerializeField] Transform PosLuz3;

    public static PersistentManagerScript Instance { get; private set; }

    public bool TerminouPass;
    public bool TerminouLab;
    public bool TerminouMin;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public bool PortalPassDesativado = false;
    public bool PortalMinDesativado = false;
    public bool PortalLabDesativado = false;

    public void InstanciaUrso()
    {
        PortalLabDesativado = true;
        FixedUpdate();
        Instantiate(Urso, PosUrso.transform.position, PosUrso.transform.rotation);
        Instantiate(Luz2, PosLuz2.transform.position, PosLuz2.transform.rotation);
    }

    public void InstanciaPapeis()
    {
        PortalPassDesativado = true;
        FixedUpdate();
        Instantiate(Papeis, PosPapel.transform.position, PosPapel.transform.rotation);
        Instantiate(Luz1, PosLuz1.transform.position, PosLuz1.transform.rotation);
    }

    public void InstanciaTelemovel()
    {
        PortalMinDesativado = true;
        FixedUpdate();
        Instantiate(Telemovel, PosTelemovel.transform.position, PosTelemovel.transform.rotation);
        Instantiate(Luz3, PosLuz3.transform.position, PosLuz3.transform.rotation);
    }

    void FixedUpdate()
    {
        if (PortalPassDesativado == true)
        {
            PortalPass.GetComponent<Collider>().isTrigger = false;
            PortalP.GetComponent<MeshRenderer>().material = PortalDesativado;
        }

        if (PortalLabDesativado == true)
        {
            PortalLab.GetComponent<Collider>().isTrigger = false;
            PortalL.GetComponent<MeshRenderer>().material = PortalDesativado;
        }

        if (PortalMinDesativado == true)
        {
            PortalMin.GetComponent<Collider>().isTrigger = false;
            PortalM.GetComponent<MeshRenderer>().material = PortalDesativado;
        }
    }
}