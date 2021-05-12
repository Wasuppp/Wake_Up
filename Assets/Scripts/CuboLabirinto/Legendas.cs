using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class Legendas : MonoBehaviour
{
    [SerializeField] GameObject Caixatexto;

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

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "Voz - Não te lembras? Tu estiveste sempre aqui!";
        yield return new WaitForSeconds(3);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "Voz - O Mundo gira à tua volta.";
        yield return new WaitForSeconds(3);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "Voz - Onde as duas faces se encontram, o caminho continua.";
        yield return new WaitForSeconds(3);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(6);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "Voz - A resposta para o futuro está no presente.";
        yield return new WaitForSeconds(20);

        Caixatexto.GetComponent<TextMeshProUGUI>().text = "Voz - Procura a chave do teu passado na terceira rotação...";
        yield return new WaitForSeconds(30);

    }

    // Michael - Como é que vim aqui parar?
    // Narrador - Tu sempre estiveste aqui. Não te lembras?

    // Narrador - Na tua mente, o Mundo gira à tua volta.
    // Narrador - Onde as duas faces se encontram, o caminho continua.
    // Narrador - Não percas a direção.
    // Narrador - A resposta para o futuro está no presente...
    // Narrador - Procura a chave do teu passado na terceira rotação...
}
