using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class comandos : MonoBehaviour
{
    public Text txtPontos;
    public Text txtRecord;

    private void Start()
    {
        txtPontos.text = "Score : " + PlayerPrefs.GetInt("savePontos").ToString();
        txtRecord.text = "Record : " + PlayerPrefs.GetInt("saveRecord").ToString();
    }

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
