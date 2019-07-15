using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Abeja : MonoBehaviour {

    protected Joystick joystick;
    protected Joybutton joybutton;
  

    void Start () {

        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();

    }
	
	// Update is called once per frame
	void Update () {

        var rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = new Vector3(joystick.Vertical * 50f,
                                          rigidbody.velocity.y,
                                          joystick.Horizontal * 50f);

        rigidbody.velocity = new Vector3(joystick.Horizontal * 50f,
                                         rigidbody.velocity.y,
                                         joystick.Vertical * 50f);

        rigidbody.velocity = new Vector3(joystick.Vertical * 50f,
                                         rigidbody.velocity.x,
                                         joystick.Horizontal * 50f);

        rigidbody.velocity = new Vector3(joystick.Horizontal * 50f,
                                         rigidbody.velocity.x,
                                         joystick.Vertical * 50f);

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
