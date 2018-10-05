using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrontScript : MonoBehaviour {
	public Text scoreText;
	public Text highScoreText;
	public Text returnToStart;
	public GameObject coin;
	public GameObject player;
	public GameObject explosion;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Wall") {
			FindObjectOfType<GameManagerScript> ().Explosion ();
			this.gameObject.SetActive(false);
			player.gameObject.SetActive(false);
			highScoreText.gameObject.SetActive (true);
			returnToStart.gameObject.SetActive (true);
			Instantiate (explosion, transform.position,transform.rotation);
			GameManagerScript.gameover = true;
			UpperWallScript.speed = 0;
		}
	}
}
