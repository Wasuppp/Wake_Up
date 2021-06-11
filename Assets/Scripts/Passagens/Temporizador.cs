using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour
{
    Image BarraTempo;
    [SerializeField] float TempoMaximo;

    float TempoRestante;

    private void Start()
    {
        BarraTempo = GetComponent<Image>();
        TempoRestante = TempoMaximo;
    }

    private void Update()
    {
        if (TempoMaximo > 0f)
        {
            TempoRestante -= Time.deltaTime;
            BarraTempo.fillAmount = TempoRestante / TempoMaximo;
        }
        else
        {

        }

    }
}
