using UnityEngine;
using System.Collections;

public class HealthSlimLV1 : MonoBehaviour {

	public static int hitPoints;
/*	public GameObject inputHandler2D;
	public GameObject pauseScreenGO;
	public GameObject tryAgainGO;
	public GameObject mainMenuGO;
	public GameObject pauseButton;
	public GameObject gameOver;
	public GameObject mainCamera;
	public GameObject timer;
	public AudioClip alone;

	
	public GameObject[] health;
*/	
	void Start() {
		hitPoints = 3;
	}
	
	void Update () {
/*
	if(hitPoints<1)
		{
			health[3].SetActive(true);
			health[2].SetActive(false);
			health[1].SetActive(false);
			health[0].SetActive(false);
			this.collider2D.enabled = false;
			inputHandler2D.SetActive(false);
			pauseButton.SetActive(false);
			pauseScreenGO.SetActive(true);
			mainCamera.audio.Stop();
			audio.PlayOneShot(alone);
			Invoke("GameOverScreen", 1.0f);
		}
*/
	}
	
	static public void HitPoint(){
		hitPoints--;
	}
/*	
	void GameOverScreen() {
		gameOver.SetActive(true);
		tryAgainGO.SetActive(true);
		mainMenuGO.SetActive(true);
	}
*/
}

