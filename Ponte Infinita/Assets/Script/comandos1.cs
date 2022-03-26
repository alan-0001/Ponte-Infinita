using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class comandos1 : MonoBehaviour
{
    public string nomeCena;

    // Update is called once per frame
    void Update()
    {
        ///MANEIRA DE USADA DIRETO NO CONSOLE

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(nomeCena);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene(nomeCena);
        }

    }
}
