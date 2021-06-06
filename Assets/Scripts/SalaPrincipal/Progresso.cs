using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progresso: MonoBehaviour
{
    [SerializeField] GameObject Urso;
    [SerializeField] Transform PosicaoUrso;
    [SerializeField] Light Luz2;
    [SerializeField] Transform PosLuz2;

    [SerializeField] GameObject Papeis;
    [SerializeField] Transform PosicaoPapeis;
    [SerializeField] Light Luz1;
    [SerializeField] Transform PosLuz1;

    [SerializeField] GameObject Telemovel;
    [SerializeField] Transform PosicaoTelemovel;
    [SerializeField] Light Luz3;
    [SerializeField] Transform PosLuz3;

    bool acabouCuboLabirinto = false;
    bool acabouPassagens = false;
    bool acabouMinijogos = false;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void InstanciaUrso()
    {
        Instantiate(Urso, PosicaoUrso.transform.position, PosicaoUrso.transform.rotation);
        Instantiate(Luz2, PosLuz2.transform.position, PosLuz2.transform.rotation);   
    }

    public void InstanciaPapeis()
    {
        Instantiate(Papeis, PosicaoPapeis.transform.position, PosicaoPapeis.transform.rotation);
        Instantiate(Luz1, PosLuz1.transform.position, PosLuz1.transform.rotation);
    }

    public void InstanciaTelemovel()
    {
        Instantiate(Telemovel, PosicaoTelemovel.transform.position, PosicaoTelemovel.transform.rotation);
        Instantiate(Luz3, PosLuz3.transform.position, PosLuz3.transform.rotation);
    }
}
