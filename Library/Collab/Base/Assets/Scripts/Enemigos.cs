using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour{

	public GameObject Abeja;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag=="Player"){
			Debug.Log("Colison");
            Abeja.SetActive(false);
			//Destroy(Abeja);
		 }
        else if (other.tag == "borde")
        {
            Debug.Log("muerto!!!!");
            this.gameObject.SetActive(false);
            //Abeja.SetActive(false);
            //Destroy(Abeja);
        }
	}
}
