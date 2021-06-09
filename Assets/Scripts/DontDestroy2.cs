using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy2 : MonoBehaviour
{
    public static DontDestroy2 Instanciado2 { get; private set; }

    private void Awake()
    {
        if (Instanciado2 == null)
        {
            Instanciado2 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
