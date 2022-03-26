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
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        float velocidade = controleGame.velocidadePersonagem;

        rBody.velocity = new Vector2(horizontal * velocidade, vertical * velocidade);

        ////////////////////////////////////////////////////////////

        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Moved)
            {
                transform.position += (Vector3)t.deltaPosition / 500;
            }
        }

        ///////////////////////////////////////////////////////////

        //Para jogos de nave...

        //if (Input.touchCount > 0)
        //{
        //    Touch t = Input.GetTouch(0);
        //    Vector3 pos = Camera.main.ScreenToWorldPoint(t.position);
        //    pos.z = 0;
        //    transform.position = pos;
        //}

        /////////////////////////////////////////////////////////////
        //if (Input.touchCount > 0)
        //{
        //    Touch t = Input.GetTouch(0);
        //    if (t.phase == TouchPhase.Moved)
        //    {
        //        if (t.deltaPosition.y > 0)
        //        {
        //            transform.position = Vector3.up * 2;
        //        }

        //        if (t.deltaPosition.y < -0)
        //        {
        //            transform.position = Vector3.up * -2;
        //        }
        //    }
        //}

        //VERIFICA POSIÇÃO Y DO PLAYER E AJUSTA CONFORME LIMITE DEFINIDO
        if (transform.position.y > controleGame.limiteYMaximo)
        {
            transform.position = new Vector3(transform.position.x, controleGame.limiteYMaximo, 0);
        }
        else if (transform.position.y < controleGame.limiteYMinimo)
        {
            transform.position = new Vector3(transform.position.x, controleGame.limiteYMinimo, 0);
        }

        //VERIFICA POSIÇÃO X DO PLAYER E AJUSTA CONFORME LIMITE DEFINIDO
        if (transform.position.x > controleGame.limiteXMaximo)
        {
            transform.position = new Vector3(controleGame.limiteXMaximo, transform.position.y, 0);
        }
        else if (transform.position.x < controleGame.limiteXMinimo)
        {
            transform.position = new Vector3(controleGame.limiteXMinimo, transform.position.y, 0);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("moeda"))
        {
            controleGame.Pontuar();
            Destroy(collision.gameObject);
            
        }

        if (collision.gameObject.CompareTag("barril"))
        {
            controleGame.GameOver();
        }

    }
}
