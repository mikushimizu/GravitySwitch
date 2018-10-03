using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperWallScript : MonoBehaviour {
	public static float speed = 2.0f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 20);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += -Vector3.right * speed * Time.deltaTime;
		
	}
}
