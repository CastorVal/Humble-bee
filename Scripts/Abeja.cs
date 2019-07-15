using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;


public class Abeja : MonoBehaviour {

   
    public int floresTocadas = 0;
    public float enemigosTocados = 0;
    public float cargasDePolen = 0;
    public Animator Herido;

    public float maxCarga = 1f;
    public float minCarga = 0f;

    public Slider slider;
	public Slider life;

    public int conFlowN = 0;
    public Text Flower;
    public Text Pollini;


    //tener el game object que muestra el texto del nivel
    public Text nivel;
    public int numeroNivel = 0;
   

    public Text ScoreW;
    public Text Score;
    

    void Start () {

        
       
        enemigosTocados = 5f;
      

    }
	
	// Update is called once per frame
	void Update () {

        slider.value = cargasDePolen;
        life.value = enemigosTocados;

        Flower.text = ("Flowers:  " + floresTocadas);
        string nuevo = "Pollinitation:  " + conFlowN;
        Pollini.text = (nuevo);

        nivel.text = ("" + numeroNivel);
        Score.text = ("Pollinitation: " + conFlowN);
        ScoreW.text = ("Pollinitation: " + conFlowN);

        
        var rigidbody = GetComponent<Rigidbody2D>();


    }

    void OnTriggerEnter2D(Collider2D other)
    {
       

        if (other.CompareTag("Enemigo"))
        {
			enemigosTocados-=1.25f;
            Debug.Log("auch");
            Herido.SetBool("Herido", true);
        }
        
      

        if (other.CompareTag("florP"))
        {
            Destroy(other.gameObject);
            floresTocadas++;
            cargasDePolen+=0.5f;
            if (cargasDePolen > 1)
            {
                cargasDePolen = 1;

            }
           
            
            
        }

        if (other.CompareTag("florN"))
        {
            floresTocadas++;
            Destroy(other.gameObject);
            if (cargasDePolen>=0.5f)
            {
                conFlowN += 1;
            }
            cargasDePolen-=0.2f;
            if(cargasDePolen<0){
                cargasDePolen = 0;

            }
        }


    }

    void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Enemigo"))
        {
            Debug.Log("y");
            Herido.SetBool("Herido", false);
        }
    }


}
