using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour{
    public int maxHealth;
    private int health;
	public GameObject Abeja;

    void Start()
    {
        this.health = maxHealth;
    }

   public void ModifyHealth(int amount)
    {
        this.health += health;
        
        if(this.health <= 0)
        {
            this.health = 0;
            this.OnDeaath();
        }else if (this.health > this.maxHealth)
        {
            this.health = maxHealth;
        }
    }
    public virtual void OnDeaath()
    {
        Destroy(this.gameObject);
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
