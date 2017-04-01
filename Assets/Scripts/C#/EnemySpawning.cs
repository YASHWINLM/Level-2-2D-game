using UnityEngine;
using System.Collections;

public class EnemySpawning : MonoBehaviour {
	public GameObject Enemy;
	Random rand= new Random();

	// Use this for initialization
	void Start () {
		StartCoroutine ("StartSpawnCoroutine");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator StartSpawnCoroutine(){
		while(true){
			yield return new WaitForSeconds (5);
			Instantiate (Enemy,new Vector2(Random.Range(0,6), 1.15f), Quaternion.identity);
		}	
	}
}
