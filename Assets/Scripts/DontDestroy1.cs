using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy1 : MonoBehaviour
{
    public static DontDestroy1 Instanciado1 { get; private set; }

    private void Awake()
    {
        if (Instanciado1 == null)
        {
            Instanciado1 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
