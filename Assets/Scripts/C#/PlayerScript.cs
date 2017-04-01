using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public GUIStyle skin;
	public GameObject bullet;
	private bool InFront;
	public Vector2 speed = new Vector2 (50, 50);
	private Vector2 movement;
	private Rigidbody2D RigidBodyComponent;
	public int health=500;
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
			gameObject.transform.SetParent (this.transform);
			gameObject.transform.localPosition = new Vector2 (1f, -0.1f);

		}
	

	}
	void OnCollisionEnter2D(Collision2D col) {
		if(col.transform.name.Equals("jack(Clone)")){
			Debug.Log (health-=500);

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
		if(InFront){
			GUI.Label (new Rect(100,100,260,100),"Press the up arrow to enter the Houses to collect ammo and money!");

		}
		if(health==0){
			GUI.Label (new Rect(50,50,500,500),"Mission Failed we'll get 'em next time", skin);
		}
	}
}
