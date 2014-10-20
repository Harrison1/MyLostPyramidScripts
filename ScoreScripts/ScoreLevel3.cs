using UnityEngine;
using System.Collections;

public class ScoreLevel3 : MonoBehaviour {

	static int score = 0;
	
	public GameObject whiteFade;
	public GameObject i;
	public GameObject will;
	public GameObject travel;
	public GameObject to;
	public GameObject the;
	public GameObject edge;
	public GameObject inputHandler2D;
	public GameObject smlPyramid;
	public GameObject grnBarBox;
	public GameObject orgBarBox;
	public GameObject rdBarBox;
	public AudioClip levelComplete;

	int level3score = 0;

	void Start(){
		score = 0;
	}
	
	static public void AddPoint(){
		score+=1;
	} 
	
	void Update () {
		string pts = score.ToString();
		guiText.text = pts + "/100";
		
		if(score==100) {
			level3score = 1 + PlayerPrefs.GetInt("level3score");
			PlayerPrefs.SetInt("level3score", level3score);
			grnBarBox.collider2D.enabled = false;
			orgBarBox.collider2D.enabled = false;
			rdBarBox.collider2D.enabled = false;
			PyramidLV1End lvlEnd = smlPyramid.transform.GetComponent<PyramidLV1End>();
			lvlEnd.PlayPyramidLVEndAnim();
			audio.PlayOneShot(levelComplete);
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


