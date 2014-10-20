using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	static int score = 0;
	static public int scoreb = 0;
	public string playerName;
	public string tempName;
	public string playerNameStored;
	public int tempScore;
	public int current;
	public string hiscore;
	public bool playerDead;

	int newScore;
	string newName;
	int oldScore;
	string oldName;

	void Start(){
		score = 0;
		scoreb = 0;
		playerDead = false;
		TextField.userHasHitReturn = false;
	}
	
 	static public void AddPoint(){
		score+=100;
		scoreb+=100;
	} 

	void Update () {
		string pts = score.ToString();
		guiText.text = pts;

		if(HealthLVC.hitPoints < 1 && !playerDead && TextField.userHasHitReturn == true) {
			AddScore(PlayerPrefs.GetString("playername"), score);
		}
	}

	void AddScore(string name, int score){

		playerDead=true;

		newScore = score;
		newName = name;
		
		for(int i=1;i<=5;i++){
			if(PlayerPrefs.HasKey("hiscore"+i)){
				if(PlayerPrefs.GetInt("hiscore"+i)<newScore){ 
					// new score is higher than the stored score
					oldScore = PlayerPrefs.GetInt("hiscore"+i);
					oldName = PlayerPrefs.GetString("hiname"+i);
					PlayerPrefs.SetInt("hiscore"+i,newScore);
					PlayerPrefs.SetString("hiname"+i,newName);
					newScore = oldScore;
					newName = oldName;
				}
			}else{
				PlayerPrefs.SetInt("hiscore"+i,newScore);
				PlayerPrefs.SetString("hiname"+i,newName);
				newScore = 0;
				newName = "";
			}
		}
	}
}
