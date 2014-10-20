using UnityEngine;
using System.Collections;

public class CountdownClockLV3 : MonoBehaviour {

	public float timer = 120.0f;
	public int seconds;
	public int minutes;
	public GameObject healthBar;
	public GameObject whiteFade;
	public GameObject i;
	public GameObject will;
	public GameObject travel;
	public GameObject to;
	public GameObject the;
	public GameObject edge;
	public GameObject inputHandler2D;
	
	public string lastTime;
	int level3score = 0;
	
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
			level3score = 1 + PlayerPrefs.GetInt("level3score");
			keepCounting = false;
			PlayerPrefs.SetInt("level3score", level3score);
			whiteFade.SetActive(true);
			inputHandler2D.SetActive(false);
			Invoke("ActivateI", 4);
			Invoke("ActivateWill", 4);
			Invoke("ActivateTravel", 5);
			Invoke("ActivateTo", 5);
			Invoke("ActivateThe", 6);
			Invoke("ActivateEdge", 6);
			Invoke("LoadEther", 10);
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
	
	void LoadEther(){
		Application.LoadLevel("Level4");
	}

	void ActivateI(){
		i.SetActive(true);
	}
	
	void ActivateWill(){
		will.SetActive(true);
	}
	
	void ActivateTravel(){
		travel.SetActive(true);
	}

	void ActivateTo(){
		to.SetActive(true);
	}
	
	void ActivateThe(){
		the.SetActive(true);
	}
	
	void ActivateEdge(){
		edge.SetActive(true);
	}
	
}
