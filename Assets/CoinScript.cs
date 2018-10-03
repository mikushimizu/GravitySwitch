using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinScript : MonoBehaviour {
	void Start () {
		Destroy (gameObject, 10);
	}

	void Update () {
		transform.position += -Vector3.right * UpperWallScript.speed * Time.deltaTime;
		transform.Rotate (new Vector3 (2, 2, 2));
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Player") {
			FindObjectOfType<GameManagerScript> ().AddPoint (1);
			Destroy (this.gameObject);
		}
	}

}

