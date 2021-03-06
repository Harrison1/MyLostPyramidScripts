using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Health : MonoBehaviour {

	public static int hitPoints;
	public GameObject inputHandler2D;
	public GameObject pauseScreenGO;
	public GameObject tryAgainGO;
	public GameObject mainMenuGO;
	public GameObject pauseButton;
	public GameObject gameOver;
	public GameObject mainCamera;
	public GameObject pyramidBig;
	public GameObject timer;
	public GameObject lastTime;
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
			timer.SetActive(false);
			lastTime.SetActive(true);
			inputHandler2D.SetActive(false);
			pauseButton.SetActive(false);
			pauseScreenGO.SetActive(true);
			mainCamera.audio.Stop();
			pyramidBig.animation.enabled = false;
			audio.PlayOneShot(alone);
			Invoke("GameOverScreen", 1.0f);
		}

	}

	static public void HitPoint(){
		hitPoints--;
	}

	void GameOverScreen() {
		gameOver.SetActive(true);
		tryAgainGO.SetActive(true);
		mainMenuGO.SetActive(true);
	}
}


/*		switch (hitPoints) 
		{
		case 3:
			health[0].SetActive(true);
			break;
		
		case 2:
			health[1].SetActive(true);
			health[0].SetActive(false);
			break;

		default:
			if(hitPoints < 0)
			{
				health[2].SetActive(true);
				health[1].SetActive(false);
			}
		break;

		}
	} */
