using UnityEngine;
using System.Collections;

public class BulletMover : MonoBehaviour {
	PlayerScript player;
	bool playerWasTurnedLeft;
	float originalX;
	// Use this for initialization
	void Start () {
		player=GameObject.Find ("github_octocat").GetComponent<PlayerScript> ();
		playerWasTurnedLeft = player.TurnedLeft;
	}

	public void frick(float x) {
		originalX = x;
	}
		
	
	// Update is called once per frame
	void Update () {
		

		if(this.transform.position.x+originalX>20|| originalX-this.transform.position.x>20){
			
			Destroy (this.gameObject);

		}
		//Debug.Log (playerWasTurnedLeft);
		if (playerWasTurnedLeft) {
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
