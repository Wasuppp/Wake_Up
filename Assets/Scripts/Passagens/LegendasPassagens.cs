using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LegendasPassagens : MonoBehaviour
{
    [SerializeField] GameObject Caixatexto;

    void Start()
    {
        StartCoroutine(Sequencia());
    }

    IEnumerator Sequencia()
    {
        yield return new WaitForSeconds(1);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "Michael - Isto é um sonho?";
        yield return new WaitForSeconds(3);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "Voz - Sim ... e não ...";
        yield return new WaitForSeconds(3);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "O que devo fazer?";
        yield return new WaitForSeconds(3);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "< Cada ilha contém-se a si mesmo. >";
        yield return new WaitForSeconds(3);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "< Roda o chão em que estás. >";
        yield return new WaitForSeconds(3);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "< Chega ao cubo gigante, e descobre quem tu és ... >";
        yield return new WaitForSeconds(3);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);
    }
}
