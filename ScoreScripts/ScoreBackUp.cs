using UnityEngine;
using System.Collections;

public class ScoreBackUp : MonoBehaviour {

	static public int scoreBack = 0;
	
	void Start(){
		scoreBack = 0;
	}
	
	static public void AddPointBack(){
		scoreBack+=100;
	} 
	
	void Update () {
		string cpts = scoreBack.ToString();
		guiText.text = cpts;
	}
}