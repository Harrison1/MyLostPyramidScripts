using UnityEngine;
using System.Collections;

public class CountdownClockLV2 : MonoBehaviour {

	public float timer = 120.0f;
	public int seconds;
	public int minutes;
	public GameObject healthBar;
	public GameObject whiteFade;
	public GameObject im;
	public GameObject still;
	public GameObject looking;
	public GameObject inputHandler2D;
	
	public string lastTime;
	int level2score = 0;
	
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
			level2score = 1 + PlayerPrefs.GetInt("level2score");
			keepCounting = false;
			PlayerPrefs.SetInt("level2score", level2score);
			whiteFade.SetActive(true);
			inputHandler2D.SetActive(false);
			Invoke("ActivateIm", 4);
			Invoke("ActivateStill", 5);
			Invoke("ActivateLooking", 6);
			Invoke("LoadHeaven", 10);
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
	
	void LoadHeaven(){
		Application.LoadLevel("Level3");
	}

	void ActivateIm(){
		im.SetActive(true);
	}
	
	void ActivateStill(){
		still.SetActive(true);
	}
	
	void ActivateLooking(){
		looking.SetActive(true);
	}
	
}
