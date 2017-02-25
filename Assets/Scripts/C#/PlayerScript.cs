using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public Vector2 speed = new Vector2 (50, 50);
	private Vector2 movement;
	private Rigidbody2D RigidBodyComponent;
	// Use this for initialization

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis("Horizontal");

		movement = new Vector2 (inputX * speed.x, 0);
	}

	void FixedUpdate(){
		if(RigidBodyComponent == null){
			RigidBodyComponent = GetComponent<Rigidbody2D> ();
		
		}
		RigidBodyComponent.velocity = movement;
	}
}
