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
        Instantiate(Urso, PosUrso.transform.position, PosUrso.transform.rotation);
        Instantiate(Luz2, PosLuz2.transform.position, PosLuz2.transform.rotation);
        Portais.VerificaProgressoLab();
        Debug.Log("Desativa Labirinto");
    }

    public void InstanciaPapeis()
    {
        Instantiate(Papeis, PosPapel.transform.position, PosPapel.transform.rotation);
        Instantiate(Luz1, PosLuz1.transform.position, PosLuz1.transform.rotation);
        Portais.VerificaProgressoPass();
        Debug.Log("Desativa Passagens");
    }

    public void InstanciaTelemovel()
    {
        Instantiate(Telemovel, PosTelemovel.transform.position, PosTelemovel.transform.rotation);
        Instantiate(Luz3, PosLuz3.transform.position, PosLuz3.transform.rotation);
        Portais.VerificaProgressoMin();
        Debug.Log("Desativa Minijogos");
    }
}
