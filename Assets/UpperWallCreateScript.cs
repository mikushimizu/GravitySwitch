using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperWallCreateScript : MonoBehaviour {
	public GameObject wall;
	float timer = 0f;
	float interval = 0.48f;
	// Use this for initialization
	void Start () {
		for (int x = 0; x < 12; x++) {
			transform.position = new Vector3 (x*2-10, Random.Range (0, 3), 0);
			Instantiate (wall, transform.position, transform.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= interval) {
			transform.position = new Vector3 (12, Random.Range (0, 3), 0);
			Instantiate (wall, transform.position, transform.rotation);
			timer = 0;
		}
	}
}
