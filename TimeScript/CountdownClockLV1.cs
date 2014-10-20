using UnityEngine;
using System.Collections;

public class CountdownClockLV1 : MonoBehaviour {

	public float timer = 120.0f;
	public int seconds;
	public int minutes;
	public GameObject healthBar;
	public GameObject whiteFade;
	public GameObject where;
	public GameObject are;
	public GameObject you;
	public GameObject inputHandler2D;

	public string lastTime;

	int level1score = 0;

	bool keepCounting;

	void Start(){
		keepCounting = true;
	}

	void Update() {

		if(keepCounting == true){
			CountDownTimer ();
		}

		//Debug.Log (timer);
		
		if(seconds == 0.0f && minutes == 0.0f && keepCounting==true) {
			healthBar.collider2D.enabled = false;
			level1score = 1 + PlayerPrefs.GetInt("level1score");
			keepCounting = false;
			PlayerPrefs.SetInt("level1score", level1score);
			Debug.Log(PlayerPrefs.GetInt("level1score"));
			whiteFade.SetActive(true);
			inputHandler2D.SetActive(false);
			Invoke("ActivateWhere", 4);
			Invoke("ActivateAre", 5);
			Invoke("ActivateYou", 6);
			Invoke("LoadEarth", 10);
		}

	}

	void CountDownTimer(){
		timer -= Time.deltaTime;
		minutes = Mathf.FloorToInt(timer / 60F);
		seconds = Mathf.FloorToInt(timer - minutes * 60);
		string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
		guiText.text = niceTime;
		lastTime = niceTime;
	}

	void LoadEarth(){
		Application.LoadLevel("Level2");
	}

	void ActivateWhere(){
		where.SetActive(true);
	}

	void ActivateAre(){
		are.SetActive(true);
	}

	void ActivateYou(){
		you.SetActive(true);
	}
	
}
