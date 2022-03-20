using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOffset : MonoBehaviour
{
    public Renderer renderizador;
    private Material materialAtual;
    public float incrementoOffset;
    public int ordemRenderizacao;
    private float offSet;
    public float velocidade;

    void Start()
    {
        renderizador = GetComponent<Renderer>();
        renderizador.sortingOrder = ordemRenderizacao;
        materialAtual = renderizador.material;
    }

    // Update is called once per frame
    void Update()
    {
        offSet += incrementoOffset;
        materialAtual.SetTextureOffset("_MainTex", new Vector2(offSet * velocidade, 0));
    }
}
