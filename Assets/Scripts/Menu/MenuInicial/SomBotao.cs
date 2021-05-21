using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomBotao : MonoBehaviour
{
    AudioSource BotaoSom;

    private void Start()
    {
        BotaoSom = GetComponent<AudioSource>();
    }

    public void TocaSom()
    {
        BotaoSom.Play();
    }

}
