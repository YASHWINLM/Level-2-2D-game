﻿using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public GUIStyle skin;
	public GameObject bullet;
	private bool InFront;
	public Vector2 speed = new Vector2 (50, 50);
	private Vector2 movement;
	private Rigidbody2D RigidBodyComponent;
	public float health=500f;
	public Texture2D emptyTex;
	public Texture2D fullTex;
	public GUIStyle progress_empty;
	public GUIStyle progress_full;

	//current progress
	public float barDisplay;

	Vector2 pos = new Vector2(0,0);
	Vector2 size = new Vector2(250,50);

	// Use this for initialization

	void Start () {
		RigidBodyComponent = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if(InFront){

			if(Input.GetKeyDown(KeyCode.UpArrow)){
				GetComponent<SpriteRenderer> ().enabled=false;


			} else if(Input.GetKeyDown(KeyCode.DownArrow)){
				GetComponent<SpriteRenderer> ().enabled=true;
			}
		}
		if(GetComponent<SpriteRenderer> ().enabled){
			float inputX = Input.GetAxis("Horizontal");

			movement = new Vector2 (inputX * speed.x, 0);
		}
		if(Input.GetKeyDown(KeyCode.Space)){
			GameObject gameObject=(GameObject)Instantiate (bullet,new Vector2(1f,-0.31f), Quaternion.identity);
			gameObject.transform.localPosition = this.transform.localPosition;

		}
		//the player's health
		barDisplay =health/500f;

	}
	void OnCollisionEnter2D(Collision2D col) {
		if(col.transform.name.Equals("jack(Clone)")){
			Debug.Log (health-=5);


		}
		if(health==0){
			GetComponent<SpriteRenderer> ().enabled=false;
			Destroy (Camera.main);


		}
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
		//draw the background:
		GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y), emptyTex, progress_empty);

		GUI.Box(new Rect(pos.x, pos.y, size.x, size.y), fullTex, progress_full);

		//draw the filled-in part:
		GUI.BeginGroup(new Rect(0, 0, size.x * barDisplay, size.y));
		GUI.Box(new Rect(0, 0, size.x, size.y), fullTex, progress_full);

		GUI.EndGroup();
		GUI.EndGroup();
		if(InFront){
			GUI.Label (new Rect(100,100,260,100),"Press the up arrow to enter the Houses to collect ammo and money!");

		}
		if(health==0){
			GUI.Label (new Rect(50,50,500,500),"Mission Failed we'll get 'em next time", skin);
		}
	}
}
