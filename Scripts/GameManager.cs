using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    Abeja Sabeja;//instanciar
    Spawner Aspawner;

    public static bool GameIsOver = false;
    //UI
    public GameObject FinDeJuegoUI;
    public GameObject Lvl;
    public GameObject GameoverUI;
    public GameObject LevelUpUI;
    // Use this for initialization
    void Start() {
        Lvl.SetActive(true);
        Sabeja = GameObject.Find("abeja").GetComponent<Abeja>();//que cosa tiene el script

        Aspawner = GameObject.Find("Spawner").GetComponent<Spawner>();

        if (Sabeja.conFlowN>=5)
        {
            Sabeja.numeroNivel ++;
            Aspawner.tiempoMin -= 0.1f;
            Aspawner.tiempoMax -= 0.1f;
            LevelUpUI.SetActive(true);
        }
        if (Sabeja.numeroNivel==20 && Sabeja.conFlowN ==100)
        {
            Time.timeScale = 1f;
            FinDeJuegoUI.SetActive(true);
            LevelUpUI.SetActive(false);
            Lvl.SetActive(false);
        }

        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Sabeja.enemigosTocados == 0f)//elemento publico
        {
            Time.timeScale = 1f;
            Lvl.SetActive(false);
            GameoverUI.SetActive(true);
            GameIsOver = true;
            Aspawner.generar = false;
        }

        if (Sabeja.life.value==0f)
        {
            GameIsOver = true;
            Aspawner.generar = false;
            GameoverUI.SetActive(true);
            Lvl.SetActive(false);
            LevelUpUI.SetActive(false);
        }

    }

        public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting menu...");
        Application.Quit();
    }


}
