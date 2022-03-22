using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class comandos : MonoBehaviour
{
    public string nomeCena;

    // Update is called once per frame
    void Update()
    {
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
