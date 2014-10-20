using UnityEngine;
using System.Collections;

public class ScoreLevel : MonoBehaviour {

	static int score = 0;

	public GameObject whiteFade;
	public GameObject where;
	public GameObject are;
	public GameObject you;
	public GameObject inputHandler2D;
	public GameObject smlPyramid;
	public GameObject grnBarBox;
	public GameObject orgBarBox;
	public GameObject rdBarBox;
	public AudioClip levelComplete;

	int level1score = 0;
	
	void Start(){
		score = 0;
	}
	
	static public void AddPoint(){
		score+=1;
	} 
	
	void Update () {
		string pts = score.ToString();
		guiText.text = pts + "/50";

		if(score==50) {
			level1score = 1 + PlayerPrefs.GetInt("level1score");
			PlayerPrefs.SetInt("level1score", level1score);
			grnBarBox.collider2D.enabled = false;
			orgBarBox.collider2D.enabled = false;
			rdBarBox.collider2D.enabled = false;
			PyramidLV1End lvlEnd = smlPyramid.transform.GetComponent<PyramidLV1End>();
			lvlEnd.PlayPyramidLVEndAnim();
			audio.PlayOneShot(levelComplete);
			whiteFade.SetActive(true);
			inputHandler2D.SetActive(false);
			Invoke("ActivateWhere", 4);
			Invoke("ActivateAre", 5);
			Invoke("ActivateYou", 6);
			Invoke("LoadEarth", 10);
		}

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

