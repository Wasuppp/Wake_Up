using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TempoMin : MonoBehaviour
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
        if (TempoRestante > 0f)
        {
            TempoRestante -= Time.deltaTime;
            BarraTempo.fillAmount = TempoRestante / TempoMaximo;
        }
        else
        {
            SceneManager.LoadScene("Cubo_Labirinto");
        }

    }
}
