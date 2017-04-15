using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	
	float MoveSpeed = 0.04f;
	int MaxDist = 10;
	int MinDist = 5;
	GameObject Player;
	Vector3 pos;

	// Use this for initialization
	void Start () {
		 pos = transform.position;
		Player= GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
		//transform.LookAt(Player.transform);

		if(Player.transform.position.x <= MinDist){
				
				transform.Translate (MoveSpeed,0f,0f);




		}
	}

}
