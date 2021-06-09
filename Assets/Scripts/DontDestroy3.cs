using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy3 : MonoBehaviour
{
    public static DontDestroy3 Instanciado3 { get; private set; }

    private void Awake()
    {
        if (Instanciado3 == null)
        {
            Instanciado3 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
