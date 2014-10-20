using UnityEngine;
using System.Collections;

public class CountdownClock : MonoBehaviour {

	public float timer = 120.0f;
	public string lastTime;
	
	void Update() {
		CountDownTimer ();
	}

	void CountDownTimer(){
		timer -= Time.deltaTime;
		int minutes = Mathf.FloorToInt(timer / 60F);
		int seconds = Mathf.FloorToInt(timer - minutes * 60);
		string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
		guiText.text = niceTime;
		lastTime = niceTime;
	}

}