using UnityEngine;
using System.Collections;

public class FirstFadeIn : MonoBehaviour {

	public float minimum = 0.0f;
	public float maximum = 1f;
	public float duration = 5.0f;
	private float startTime;
	public SpriteRenderer sprite;
	public static bool check;
	
	void Start() {
		startTime = Time.time;
		check = true;
	}
	void Update() {
		if(check)
			FadeIn();

		Invoke ("FadeOut", 2);
		//float t = (Time.time - startTime) / duration;
		//sprite.color = new Color(1f,1f,1f,Mathf.SmoothStep(minimum, maximum, t));       
	}

	void FadeIn() 
	{
		float t = (Time.time - startTime) / duration;
		sprite.color = new Color(1f,1f,1f,Mathf.SmoothStep(minimum, maximum, t)); 
	}

	void FadeOut() 
	{
		check = false;
		float t = (Time.time - startTime) / duration;
		sprite.color = new Color(1f,1f,1f,Mathf.SmoothStep(maximum, minimum, t)); 
	}
}
