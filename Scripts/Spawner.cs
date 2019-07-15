using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] objetos;

    public float tiempoMin = 1.25f;
    public float tiempoMax = 2.5f;
    public bool generar;
   
    public float timeRemaining = 30f;
    //public int numeroNivel =0;

    // Use this for initialization
    void Start () {

        generar = true;

        if(generar==true)
        {
           


            decreaseTimeRemaining();
            Generar();
        }
        
     

    }

    void Generar()
    {
        Instantiate(objetos[Random.Range(0,objetos.Length)], new Vector3(Random.Range(-6,8), transform.position.y, transform.position.z), Quaternion.identity);
        Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
       
    }

    void decreaseTimeRemaining()
    {
        timeRemaining-=1;
       

        if (timeRemaining == 0)
        {
            timeRemaining = 30f;
        }

    }
}
