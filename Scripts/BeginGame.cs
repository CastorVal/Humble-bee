using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour {

    public GameObject MenuPrin;
    public GameObject Credit;
    public GameObject Carga;

   
	// Use this for initialization
	void Start () {

        MenuPrin.SetActive(true);
        Credit.SetActive(false);
        Carga.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
 
    public void credGame(){
        MenuPrin.SetActive(false);
        Credit.SetActive(true);
       
    }
    public void tuto()
    {
        Carga.SetActive(true);
      
    }

    public void atras()
    {
        MenuPrin.SetActive(true);
        Credit.SetActive(false);
    }

	public void PlayGame() {
       
      SceneManager.LoadScene("NVL1");
        
		
	}

	public void Quit(){
		 Debug.Log("Quitting menu...");
        Application.Quit();
	}
}
