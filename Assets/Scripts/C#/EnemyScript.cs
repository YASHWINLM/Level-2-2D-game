using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	
	float MoveSpeed = 0.04f;

	PlayerScript Player;


	// Use this for initialization
	void Start () {
		
		Player = GameObject.Find ("github_octocat").GetComponent<PlayerScript>();
	}
	
	// Update is called once per frame
	void Update () {
		




		//}

		if(this.transform.position.x<Player.transform.position.x){
			
			transform.Translate (MoveSpeed,0f,0f);
		}

		if(this.transform.position.x>Player.transform.position.x){

			transform.Translate (-MoveSpeed,0f,0f);
		}
	}

}
