using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controleGame : MonoBehaviour
{
    [Header("Personagem")]
    public Transform tPlayer;
    public float velocidadePersonagem;

    [Header("Configuração Limite Movimento Personagem")]
    public float limiteYMaximo;
    public float limiteYMinimo;
    public float limiteXMaximo;
    public float limiteXMinimo;

    [Header("Configuração da GamePlay ")]
    public float velocidadeObjetos;
    public float intervaloSpawnBarril;
    public float velocidadeMoeda;
    public float intervaloSpawnMoeda;
    public int pontosGanhosPorMoeda;

    [Header("Configuração da Ponte")]
    public GameObject prefabPonte;
    public float tamanhoPrefabPonte;

    [Header("Configuração do Barril")]
    public GameObject prefabBarril;
    public float posicaoXBarril;
    public float[] posicaoYBarril;
    public int[] ordemExibicao;

    [Header("Configuração da Moeda")]
    public GameObject prefabMoeda;
    public float posicaoXMoeda;
    public float[] posicaoYMoeda;
    public int[] ordemExibicaoMoeda;

    [Header("HUD")]
    public Text txtPonto;
    private int pontos;

    [Header("fx")]
    public AudioSource Sfx;
    public AudioClip fxPonto;

    public void instanciarPonte(float posicaoX)
    {
        GameObject tempPonte = Instantiate(prefabPonte);
        tempPonte.transform.position = new Vector3(posicaoX + tamanhoPrefabPonte, tempPonte.transform.position.y, 0);
    }

    private void Start()
    {
        StartCoroutine("SpawnBarril");
        StartCoroutine("SpawnMoeda");
    }

    IEnumerator SpawnBarril()
    {
        yield return new WaitForSeconds(intervaloSpawnBarril);

        GameObject tempBarril = Instantiate(prefabBarril);
        int rand = Random.Range(0, 2);//vai ficar entre 0 e 1
        tempBarril.transform.position = new Vector3(posicaoXBarril, posicaoYBarril[rand], 0);
        tempBarril.GetComponent<SpriteRenderer>().sortingOrder = ordemExibicao[rand];

        StartCoroutine("SpawnBarril");
    }
    /// /////////////////////MOEDA////////////////////////////////////////////////
    IEnumerator SpawnMoeda()
    {
        yield return new WaitForSeconds(intervaloSpawnMoeda);

        GameObject tempMoeda = Instantiate(prefabMoeda);
        int rand = Random.Range(0, 0);//vai ficar entre 0 
        tempMoeda.transform.position = new Vector3(posicaoXMoeda, posicaoYMoeda[rand], 0);
        tempMoeda.GetComponent<SpriteRenderer>().sortingOrder = ordemExibicaoMoeda[rand];
        
        

        StartCoroutine("SpawnMoeda");
    }

    public void Pontuar()
    {
        pontos += pontosGanhosPorMoeda;
        txtPonto.text = "PONTOS: " + pontos.ToString();

        Sfx.PlayOneShot(fxPonto, 0.7f);
    }

    public void GameOver()
    {
        SceneManager.LoadScene("gameover");
    }
}
