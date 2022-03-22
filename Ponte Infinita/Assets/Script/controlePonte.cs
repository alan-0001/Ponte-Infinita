using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlePonte : MonoBehaviour
{
    private controleGame controleGame;
    private Rigidbody2D rBody;

    private bool instanciado;

    void Start()
    {
        controleGame = FindObjectOfType(typeof(controleGame)) as controleGame;
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rBody.velocity = new Vector2(controleGame.velocidadeObjetos, 0);

        if (transform.position.x <= 0 && instanciado == false)
        {
            instanciado = true;
            controleGame.instanciarPonte(transform.position.x);
        }

        if (transform.position.x <= -8)
        {
            Destroy(this.gameObject);
        }
    }
}
