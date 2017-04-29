using UnityEngine;
using System.Collections;

public class BulletMover : MonoBehaviour {
	PlayerScript player;
	// Use this for initialization
	void Start () {
		player=GameObject.Find ("github_octocat").GetComponent<PlayerScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		

		if(transform.position.x>=20){
			
			Destroy (this.gameObject);

		}
		if (player.TurnedLeft) {
			this.transform.position += new Vector3 (-0.4f, 0f);
		} else {
			transform.position += new Vector3 (0.4f, 0f);
		}
	}
	void OnCollisionEnter2D(Collision2D col) {

		if(col.transform.name.Equals("jack(Clone)")){
			Destroy (col.transform.gameObject);
			//col.transform.gameObject.SetActive(false);
			Destroy (this.gameObject);

		}

	}
}
