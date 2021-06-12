using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class LegendasLabirinto : MonoBehaviour
{
    [SerializeField] GameObject Caixatexto;

    int Progresso = 0;

    void Start()
    {
        StartCoroutine(Sequencia());
    }

    IEnumerator Sequencia()
    {      
            yield return new WaitForSeconds(1);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "Michael - Como é que eu vim aqui parar?";
            yield return new WaitForSeconds(3);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
            yield return new WaitForSeconds(1);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "< A tua mente guiou-te até aqui. >";
            yield return new WaitForSeconds(3);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
            yield return new WaitForSeconds(1);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "O que tenho de fazer?";
            yield return new WaitForSeconds(3);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
            yield return new WaitForSeconds(1);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "< Segue a luz do teu instinto... >";
            yield return new WaitForSeconds(4);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
            yield return new WaitForSeconds(1);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "< Onde as duas faces se encontram, o caminho continua ... >";
            yield return new WaitForSeconds(5);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
            yield return new WaitForSeconds(1);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "< Procura a chave para o teu passado no quarto labirinto ... >";
            yield return new WaitForSeconds(5);

            Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
            yield return new WaitForSeconds(1);


    }

}
