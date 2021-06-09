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

    [SerializeField] PersistentManagerScript PersistentManagerScript;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
