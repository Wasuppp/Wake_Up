using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LegendasSPrincipal : MonoBehaviour
{
    [SerializeField] GameObject Caixatexto;

    bool acabajogo = false;

    void Start()
    {
        StartCoroutine(Sequencia());
    }

    public void AcabaJogo()
    {
        acabajogo = true;
    }

    IEnumerator Sequencia()
    {
        if (acabajogo == false)
        {
            yield return new WaitForSeconds(1);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "Onde é que eu estou?";
            yield return new WaitForSeconds(4);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
            yield return new WaitForSeconds(1);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "< Não te lembras? Tu estiveste sempre aqui. >";
            yield return new WaitForSeconds(4);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
            yield return new WaitForSeconds(1);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "Co ... como assim?";
            yield return new WaitForSeconds(3);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
            yield return new WaitForSeconds(1);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "< Entra na porta certa, e descobre por ti mesmo... >";
            yield return new WaitForSeconds(4);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
            yield return new WaitForSeconds(1);
        }
    }   
}
