using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controleMoeda : MonoBehaviour
{
    private controleGame controleGame;
    private Rigidbody2D rBody;
    //private bool pontuado;

    void Start()
    {
        controleGame = FindObjectOfType(typeof(controleGame)) as controleGame;
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rBody.velocity = new Vector2(controleGame.velocidadeMoeda, 0);

        //VERIFICA SE A POSIÇÃO X DO BARRIL É MENOR QUE A DO PERSONAGEM ENTÃO CHAMA A FUNÇÃO DE PONTUAÇÃO
        //if (transform.position.x <= controleGame.tPlayer.position.x && pontuado == false)
        //{
        //    controleGame.Pontuar();
        //    pontuado = true;
        //}
    }
}
