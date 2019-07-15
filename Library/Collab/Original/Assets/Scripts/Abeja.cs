using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Abeja : MonoBehaviour {

    protected Joystick joystick;
    protected Joybutton joybutton;
    public Transform aguijon;
    public GameObject aguijonPrefab;

    void Start () {

        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();

    }
	
	// Update is called once per frame
	void Update () {

        Horizontal();
        Vertical();

    }

    public void Horizontal(){

        var rigidbody = GetComponent<Rigidbody2D>();
    

        rigidbody.velocity = new Vector3(joystick.Vertical * 20f,
                                         rigidbody.velocity.x,
                                         joystick.Horizontal * 20f);

        rigidbody.velocity = new Vector3(joystick.Horizontal * 20f,
                                         rigidbody.velocity.x,
                                         joystick.Vertical * 20f);
        
        if(joystick.Horizontal>0){
            transform.localScale = new Vector3(1,1,1);
        }else
        {
            transform.localScale = new Vector3(-1,1,1);
        }
        

    }
    public void Vertical (){
        
    var rigidbody = GetComponent<Rigidbody2D>();
    rigidbody.velocity = new Vector3(joystick.Vertical * 20f,
                                          rigidbody.velocity.y,
                                          joystick.Horizontal * 20f);
        
        rigidbody.velocity = new Vector3(joystick.Horizontal * 20f,
                                         rigidbody.velocity.y,
                                         joystick.Vertical * 20f);

        if(joystick.Vertical>0){
            transform.localScale = new Vector3(1,1,1);
        }else
        {
            transform.localScale = new Vector3(1,-1,1);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "")
        {
            Debug.Log("border");
            this.gameObject.SetActive(false);
            //Destroy(Abeja);
        }
    }

    


}
