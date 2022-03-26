using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controleMoeda : MonoBehaviour
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
        rBody.velocity = new Vector2(controleGame.velocidadeMoeda, 0);
    }
}
