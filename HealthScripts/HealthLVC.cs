﻿using UnityEngine;
using System.Collections;

public class HealthLVC : MonoBehaviour {

	public static int hitPoints;
	public GameObject inputHandler2D;
	public GameObject pauseScreenGO;
	public GameObject gameOver;
	public GameObject tryAgainGO;
	public GameObject mainMenuGO;
	public GameObject pauseButton;
	public GameObject mainCamera;
	public GameObject hiscore;
	public GameObject nameInput;
	public AudioClip alone;
	
	public GameObject[] health;
	
	void Start() {
		hitPoints = 3;
	}
	
	void Update () {
		
		if (hitPoints == 3) 
		{
			health[0].SetActive(true);	
		}
		
		else if (hitPoints == 2) 
		{
			health[1].SetActive(true);
			health[0].SetActive(false);
		}
		
		else if (hitPoints == 1)
		{
			health[2].SetActive(true);
			health[1].SetActive(false);
			health[0].SetActive(false);	
		}
		
		else if(hitPoints<1)
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

				if(Score.scoreb > PlayerPrefs.GetInt("hiscore5")) {
					nameInput.SetActive(true);
				}
				else {	
					Invoke("GameOverScreen", 1.0f);
				}
		}
		
	}
	
	static public void HitPoint(){
		hitPoints--;
	}
	
	void GameOverScreen() {
		gameOver.SetActive(true);
		tryAgainGO.SetActive(true);
		mainMenuGO.SetActive(true);
		hiscore.SetActive (true);
	}
}
