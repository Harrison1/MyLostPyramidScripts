using UnityEngine;
using System.Collections;

public class ScoreLevel2 : MonoBehaviour {

	static int score = 0;

	public GameObject whiteFade;
	public GameObject im;
	public GameObject still;
	public GameObject looking;
	public GameObject inputHandler2D;
	public GameObject smlPyramid;
	public GameObject grnBarBox;
	public GameObject orgBarBox;
	public GameObject rdBarBox;
	public AudioClip levelComplete;

	int level2score = 0;
	
	void Start(){
		score = 0;
	}
	
	static public void AddPoint(){
		score+=1;
	} 
	
	void Update () {
		string pts = score.ToString();
		guiText.text = pts + "/75";
		
		if(score==75) {
			level2score = 1 + PlayerPrefs.GetInt("level2score");
			PlayerPrefs.SetInt("level2score", level2score);
			grnBarBox.collider2D.enabled = false;
			orgBarBox.collider2D.enabled = false;
			rdBarBox.collider2D.enabled = false;
			PyramidLV1End lvlEnd = smlPyramid.transform.GetComponent<PyramidLV1End>();
			lvlEnd.PlayPyramidLVEndAnim();
			audio.PlayOneShot(levelComplete);
			whiteFade.SetActive(true);
			inputHandler2D.SetActive(false);
			Invoke("ActivateIm", 4);
			Invoke("ActivateStill", 5);
			Invoke("ActivateLooking", 6);
			Invoke("LoadHeaven", 10);
		}
		
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

