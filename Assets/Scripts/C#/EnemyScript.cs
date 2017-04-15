using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	
	float MoveSpeed = 0.04f;
	int MaxDist = 10;
	int MinDist = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject Player= GameObject.FindWithTag("Player");
		transform.LookAt(Player.transform);

		if(Vector3.Distance(transform.position,Player.transform.position) >= MinDist){

			transform.position += transform.forward*MoveSpeed*Time.deltaTime;



			if(Vector3.Distance(transform.position,Player.transform.position) <= MaxDist)
			{
				//Here Call any function U want Like Shoot at here or something
			} 

		}
	}

}
