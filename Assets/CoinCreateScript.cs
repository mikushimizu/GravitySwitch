using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCreateScript : MonoBehaviour {
	public GameObject coin;
	float timer = 0;
	int interval = 2;
	float x;
	float y;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		interval = Random.Range (3, 10);
		if (timer >= interval) {
			transform.position = new Vector3 (12, Random.Range (-2, 4), 0);
			Instantiate (coin, transform.position, transform.rotation);
			timer = 0;
		}
	}
}
