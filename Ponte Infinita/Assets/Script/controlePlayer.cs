using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlePlayer : MonoBehaviour
{
    private controleGame controleGame;
    private Rigidbody2D rBody;

    void Start()
    {
        controleGame = FindObjectOfType(typeof(controleGame)) as controleGame;

        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float velocidade = controleGame.velocidadePersonagem;

        rBody.velocity = new Vector2(horizontal * velocidade, vertical * velocidade);

        if (Input.GetButtonDown("Fire1"))
        {
            //rBody.velocity = new Vector2(horizontal * velocidade, vertical * velocidade);

            rBody.velocity = Vector2.up * velocidade;
            //rigid.velocity = Vector2.up * speed;
        }

        if (Input.GetButtonUp("Fire3"))
        {
            rBody.velocity = Vector2.down*velocidade;

            //rigid.velocity = Vector2.up * speed;
        }

    }
}
