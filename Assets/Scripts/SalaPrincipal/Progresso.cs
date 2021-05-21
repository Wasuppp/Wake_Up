using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progresso: MonoBehaviour
{
    [SerializeField] GameObject Urso;
    [SerializeField] GameObject PosicaoUrso;

    [SerializeField] GameObject Papeis;
    [SerializeField] GameObject PosicaoPapeis;

    [SerializeField] GameObject Telemovel;
    [SerializeField] GameObject PosicaoTelemovel;

    bool acabouCuboLabirinto = false;
    bool acabouPassagens = false;
    bool acabouMinijogos = false;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void InstanciaUrso()
    {
        Instantiate<GameObject>(Urso, PosicaoUrso.transform.position, PosicaoUrso.transform.rotation);
    }

    public void InstanciaPapeis()
    {
        Instantiate<GameObject>(Papeis, PosicaoPapeis.transform.position, PosicaoPapeis.transform.rotation);
    }

    public void InstanciaTelemovel()
    {
        Instantiate<GameObject>(Telemovel, PosicaoTelemovel.transform.position, PosicaoTelemovel.transform.rotation);
    }
}
