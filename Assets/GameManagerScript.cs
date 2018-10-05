using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {
	public static bool gameover = false;
	public Text scoreText;
	public Text highScoreText;
	public Text returnToStart;
	public GameObject coin;
	public GameObject player;
	public GameObject explosion;

	public AudioSource Bomb;

	private int score = 0;
	private int highScore;
	private string highScoreKey = "highScore";
	// Use this for initialization
	void Start () {
		Initialize ();
	}
	
	// Update is called once per frame
	void Update () {
		if (highScore < score) {
			highScore = score;
		}
			
		scoreText.text = score.ToString ();
		highScoreText.text = "HIGH SCORE: "+highScore.ToString ();
		if (gameover == true) {
			if (Input.GetMouseButton (0)) {
				Debug.Log ("click"); 
				Restart ();
			}
		}
		Debug.Log (gameover);

		
		
	}
	private void Initialize () {
		score = 10;
		highScore = PlayerPrefs.GetInt (highScoreKey, 0);
	}

	public void Restart(){
		Save ();
		UpperWallScript.speed = 2;
		score = 0;
		this.gameObject.SetActive(true);
		player.gameObject.SetActive(true);
		highScoreText.gameObject.SetActive (false);
		returnToStart.gameObject.SetActive (false);
		SceneManager.LoadScene ("Main");
		gameover = false;

	}
	public void AddPoint (int point) {
		score = score + point;
	}


	public void Save () {
		PlayerPrefs.SetInt (highScoreKey, highScore);
		PlayerPrefs.Save ();
		Initialize ();
	}

	public void Explosion(){
		Bomb.Play ();
	}
}
