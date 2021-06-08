using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progresso: MonoBehaviour
{
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

    [SerializeField] Portais Portais;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void InstanciaUrso()
    {
        Portais.Labirinto();
        Instantiate(Urso, PosUrso.transform.position, PosUrso.transform.rotation);
        Instantiate(Luz2, PosLuz2.transform.position, PosLuz2.transform.rotation);
    }

    public void InstanciaPapeis()
    {
        Portais.Passagens();
        Instantiate(Papeis, PosPapel.transform.position, PosPapel.transform.rotation);
        Instantiate(Luz1, PosLuz1.transform.position, PosLuz1.transform.rotation);
    }

    public void InstanciaTelemovel()
    {
        Portais.Minijogos();
        Instantiate(Telemovel, PosTelemovel.transform.position, PosTelemovel.transform.rotation);
        Instantiate(Luz3, PosLuz3.transform.position, PosLuz3.transform.rotation);
    }

}
