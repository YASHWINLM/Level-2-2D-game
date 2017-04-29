using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour {
	private GameObject octoCat;
	// Use this for initialization
	void Start () {
		octoCat=GameObject.Find("github_octocat");
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3(octoCat.transform.position.x,octoCat.transform.position.y, -10);

	}
}
