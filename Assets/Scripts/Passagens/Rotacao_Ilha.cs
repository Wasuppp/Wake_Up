using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao_Ilha : MonoBehaviour
{
    // Este script é atribuído à Ilha, ou sala que vai rodar para permitir o jogador progrdir no nível
    // A mecânica consiste em que o jogador aciona o objeto de escala situado no centro da ilha para rodar 90 graus no eixo y, para um sentido ou outro
    // O problema é que, depois da 3ª rotação, se o jogador pressionar outra vez no objeto, a ilha começa a rodar infinitamente


    [SerializeField] LayerMask ImagemInteracao = 8; // 

    [SerializeField] GameObject Ilha; //Sala que entra em rotação
    [SerializeField] GameObject ObjetoRotacao; //Eixo de rotação da sala
    [SerializeField] float velocidadeRot = 20f; //Velocidade de rotação da sala
    [SerializeField] bool RotacaoPositiva = true; //Rotação a favor ou contra o sentido dos ponteiros do relogio
    [SerializeField] int NumeroDeRotacoes = 3;

    AudioSource somR;

    bool EntrouemParent = false;
 

    bool EmRotacao = false; //A sala está em rotação

    private Rigidbody Rb; //Rigidbody da Sala

    private float contadorPositivo = 90f; //Contador para a rotação poritiva
    private float contadorNegativo = 270f;//Contador para a rotação poritivanegativa

    private void Start()
    {
        Rb = GetComponent<Rigidbody>(); //É salvo o Rigid Body da sala
        somR = GetComponent<AudioSource>();
    }


    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 10, ImagemInteracao)) // Se a direção da camara do jogador estiver sobre o objeto-escala
        {
            if (Input.GetKeyDown(KeyCode.E) && EmRotacao == false) //se o jogador pressionar a tecla "E" e a sala estiver parada
            {
                EmRotacao = true; // a sala roda
                playsound();
            }
        }


        if (EmRotacao == true && RotacaoPositiva ==true && NumeroDeRotacoes >0) //rotacao a favor do sentido dos ponteiros do relógio
        {
            Ilha.transform.RotateAround(ObjetoRotacao.transform.position, new Vector3(0, 1, 0), velocidadeRot * Time.deltaTime); //A sala roda à volta do objeto de rotação, pelo eixo y, a uma velocidade constante

            if (Ilha.transform.eulerAngles.y >= contadorPositivo) // se o valor da rotação em y for maior que o valor do contador, a rotação pára
            {
                NumeroDeRotacoes -= 1;
                EmRotacao = false;
                contadorPositivo += 90f; // o contador aumenta 90 graus
            } 
        }
        else if (EmRotacao == true && RotacaoPositiva == false && NumeroDeRotacoes>0) //rotacao contra o sentido dos ponteiros do relógio
        {
            Ilha.transform.RotateAround(ObjetoRotacao.transform.position, new Vector3(0, 1, 0), -velocidadeRot * Time.deltaTime);
            Debug.Log(Ilha.transform.eulerAngles.y);

            if (Ilha.transform.eulerAngles.y <= contadorNegativo)
            {
                NumeroDeRotacoes -= 1;
                EmRotacao = false;
                contadorNegativo -= 90f;
            }
        }     

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && EntrouemParent == false)
        {
            other.transform.parent = transform; //Jogador passa para filho da sala 
            EntrouemParent = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.parent = null; //Jogador passa para filho da sala        
        }
    }

    void playsound()
    {
        somR.Play();


    }
}
