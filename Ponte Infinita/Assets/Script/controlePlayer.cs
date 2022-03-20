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


        ////////////////////////////////////////////////////////////

        //if (Input.touchCount > 0)
        //{
        //    Touch t = Input.GetTouch(0);
        //    if (t.phase == TouchPhase.Moved)
        //    {
        //        transform.position += (Vector3)t.deltaPosition / 600;
        //    }
        //}

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
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Moved)
            {
                if(t.deltaPosition.y > 1)
                {
                    transform.position = Vector3.up * 2;
                }

                if (t.deltaPosition.y < -1)
                {
                    transform.position = Vector3.up * -2;
                }
            }
        }

    }
}
