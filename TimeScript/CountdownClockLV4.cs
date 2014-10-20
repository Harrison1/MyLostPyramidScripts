using UnityEngine;
using System.Collections;

public class CountdownClockLV4 : MonoBehaviour {

	public float timer = 120.0f;
	public int seconds;
	public int minutes;
	public GameObject healthBar;
	public GameObject whiteFade;
	public GameObject pyramidText;
	public GameObject inputHandler2D;
	
	public string lastTime;
	int level4score = 0;
	
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
			level4score = 1 + PlayerPrefs.GetInt("level4score");
			keepCounting = false;
			PlayerPrefs.SetInt("level4score", level4score);
			whiteFade.SetActive(true);
			inputHandler2D.SetActive(false);
			Invoke("ActivatePyramidText", 4);
			Invoke("LoadCredits", 13);
		}
		
	}
	
	void FixedUpdate(){
		
	}
	
	void CountDownTimer(){
		timer -= Time.deltaTime;
		minutes = Mathf.FloorToInt(timer / 60F);
		seconds = Mathf.FloorToInt(timer - minutes * 60);
		string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
		guiText.text = niceTime;
		lastTime = niceTime;
	}
	
	void LoadCredits(){
		Application.LoadLevel("Credits");
	}

	void ActivatePyramidText(){
		pyramidText.SetActive(true);
	}
	
}
