using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	private bool InFront;
	public Vector2 speed = new Vector2 (50, 50);
	private Vector2 movement;
	private Rigidbody2D RigidBodyComponent;
	// Use this for initialization

	void Start () {
		RigidBodyComponent = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis("Horizontal");

		movement = new Vector2 (inputX * speed.x, 0);
		if(InFront){
			if(Input.GetKeyDown(KeyCode.UpArrow)){
				GetComponent<SpriteRenderer> ().enabled=false;

			}
		}

	}
	void OnCollisionEnter2D(Collision2D coll){
		//movement = new Vector2 (inputX * speed.x, 0);
	}
	void OnTriggerEnter2D(Collider2D colldr){
		InFront = true;
		
	}
	void OnTriggerExit2D(Collider2D colldr2){
		InFront = false;
	}
	void FixedUpdate(){
		
		RigidBodyComponent.velocity = movement;
	}
	void OnGUI(){
		if(InFront){
			GUI.Label (new Rect(100,100,260,100),"Press the up arrow to enter the Houses to collect ammo and money!");

		}
	}
}
