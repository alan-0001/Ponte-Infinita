using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controleGame : MonoBehaviour
{
    public float velocidadePersonagem;
    [Header("Configuração Limite Movimento Personagem")]
    public float limiteYMaximo;
    public float limiteYMinimo;
    public float limiteXMaximo;
    public float limiteXMinimo;

    [Header("Configuração da GamePlay ")]
    public float velocidadeObjetos;
    public float intervaloSpawnBarril;
    public int pontosGanhosPorBarril;

    [Header("Configuração da Ponte")]
    public GameObject prefabPonte;
    public float tamanhoPrefabPonte;

    [Header("Configuração do Barril")]
    public GameObject prefabBarril;
    public float posicaoXBarril;
    public float[] posicaoYBarril;
    public int[] ordemExibicao;

    [Header("HUD")]
    public Text txtPontos;
    private int pontos;

    public void instanciarPonte(float posicaoX)
    {
        GameObject tempPonte = Instantiate(prefabPonte);
        tempPonte.transform.position = new Vector3(posicaoX + tamanhoPrefabPonte, tempPonte.transform.position.y, 0);
    }

    private void Start()
    {
        StartCoroutine("spawnBarril");
    }
    IEnumerator spawnBarril()
    {
        yield return new WaitForSeconds(intervaloSpawnBarril);

        GameObject tempBarril = Instantiate(prefabBarril);
        int rand = Random.Range(0, 2);//vai ficar entre 0 e 1
        tempBarril.transform.position = new Vector3(posicaoXBarril, posicaoYBarril[rand], 0);
        tempBarril.GetComponent<SpriteRenderer>().sortingOrder = ordemExibicao[rand];

        StartCoroutine("spawnBarril");
    }

    public void pontuar()
    {
        pontos += pontosGanhosPorBarril;
    }
}
