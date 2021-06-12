using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LegendasMinijogos : MonoBehaviour
{
    [SerializeField] GameObject Caixatexto;

    void Start()
    {
        StartCoroutine(Sequencia());
    }

    IEnumerator Sequencia()
    {
        yield return new WaitForSeconds(1);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "Não sei o que faço aqui. Sinto-me perdido.";
        yield return new WaitForSeconds(4);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "< Roda os três objetos subires mais alto. >";
        yield return new WaitForSeconds(4);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = " < Está atento ao teu ambiente.";
        yield return new WaitForSeconds(3);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);

    }
}
