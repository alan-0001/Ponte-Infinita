using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public float tamanhoPrefabPonte;

    [Header("Configuração dos Prefabs")]
    public GameObject prefabPonte;
    public GameObject prefabBarril;

    public void instanciarPonte(float posicaoX)
    {
        GameObject tempPonte = Instantiate(prefabPonte);
        tempPonte.transform.position = new Vector3(posicaoX + tamanhoPrefabPonte, tempPonte.transform.position.y, 0);
    }
}
