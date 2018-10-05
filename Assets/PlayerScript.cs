using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
	int click = 0;
	public AudioSource Coin;
	public AudioSource WallTouch;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position += transform.right * speed * Time.deltaTime;

		if (Input.GetMouseButtonDown (0)) {
			Physics.gravity *= -1;

		}
	}
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Coin") {
			FindObjectOfType<GameManagerScript> ().AddPoint (1);
			Coin.Play ();
			Destroy (collision.gameObject);
		}

		if (collision.gameObject.tag == "ScoreWall") {
			FindObjectOfType<GameManagerScript> ().AddPoint (1);
			Destroy (collision.gameObject);
		}

		if (collision.gameObject.tag == "Wall") {
			Debug.Log ("Touch");
			WallTouch.Play ();
		}

	}
}
