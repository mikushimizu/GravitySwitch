using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreWallCreateScript : MonoBehaviour {
	public GameObject scoreWall;
	float timer = 0f;
	float interval = 9.98f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= interval) {
			transform.position = new Vector3 (12, -11, 0);
			Instantiate (scoreWall, transform.position, transform.rotation);
			timer = 0;
		}
	}
}
