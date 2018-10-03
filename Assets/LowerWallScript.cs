using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerWallScript : MonoBehaviour {
	public GameObject wall;
	//private float speed = 2;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 20);
	}

	// Update is called once per frame
	void Update () {
		transform.position += -Vector3.right * UpperWallScript.speed * Time.deltaTime;

	}
}
