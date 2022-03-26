using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class comandos : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nomeCena(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    public void Sair()
    {
        Application.Quit();
    }
}
