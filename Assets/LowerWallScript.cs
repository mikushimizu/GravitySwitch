using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerWallScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 20);
	}

	// Update is called once per frame
	void Update () {
		transform.position += -Vector3.right * UpperWallScript.speed * Time.deltaTime;

	}
}
