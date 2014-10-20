using UnityEngine;
using System.Collections;

public class ScoreLevel4 : MonoBehaviour {

	static int score = 0;

	public GameObject healthBar;
	public GameObject whiteFade;
	public GameObject pyramidText;
	public GameObject inputHandler2D;
	public GameObject bigPyramid;
	public GameObject grnBarBox;
	public GameObject orgBarBox;
	public GameObject rdBarBox;
	public AudioClip levelComplete;

	int level4score = 0;

	void Start(){
		score = 0;
	}
	
	static public void AddPoint(){
		score+=1;
	} 

	void Update () {
		string pts = score.ToString();
		guiText.text = pts + "/150";
		
		if(score==150) {
			healthBar.collider2D.enabled = false;
			level4score = 1 + PlayerPrefs.GetInt("level4score");
			PlayerPrefs.SetInt("level4score", level4score);
			grnBarBox.collider2D.enabled = false;
			orgBarBox.collider2D.enabled = false;
			rdBarBox.collider2D.enabled = false;
			PyramidFinal finalCut = bigPyramid.transform.GetComponent<PyramidFinal>();
			finalCut.PlayPyramidFinalAnim();
			audio.PlayOneShot(levelComplete);
			whiteFade.SetActive(true);
			inputHandler2D.SetActive(false);
			Invoke("ActivatePyramidText", 4);
			Invoke("LoadCredits", 13);
		}
	}

	void LoadCredits(){
		Application.LoadLevel("Credits");
	}
	
	void ActivatePyramidText(){
		pyramidText.SetActive(true);
	}
	
}
