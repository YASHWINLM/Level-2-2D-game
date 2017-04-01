using UnityEngine;
using System.Collections;

public class BulletMover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position+=new Vector3(0.4f, 0f);
	}
	void OnCollisionEnter2D(Collision2D col) {

		if(col.transform.name.Equals("jack(Clone)")){
			Destroy (col.transform.gameObject);
			Destroy (this.gameObject);

		}
	}
}
