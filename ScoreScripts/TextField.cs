using UnityEngine;
using System.Collections;

public class TextField : MonoBehaviour {

	static public bool userHasHitReturn = false;
	public string playerNameSet;
	public string tempName;
	public string playerName;
	public int tempScore;

	public GameObject gameOver;
	public GameObject tryAgainGO;
	public GameObject mainMenuGO;
	public GameObject hiscore;
	public GameObject newHiScore;
	public GameObject submit;
	public GameObject nameBox;

	public GUIStyle nameInputBox;

	private TouchScreenKeyboard keyboard;
	

	void Start(){
		userHasHitReturn = false;
		playerNameSet = "";
		SubmitName.submitted = false;

		keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, false, true);
		TouchScreenKeyboard.hideInput = true;
	}

	void Update()
	{
		if (keyboard.active)
			{
				if (keyboard.text.Length > 3)
				{
					keyboard.text = keyboard.text.Substring(0, 3);
				}
				
				playerNameSet = keyboard.text;
			}

		guiText.text = playerNameSet;

	}	

	void OnGUI() {

		Event e = Event.current;
		if (e.keyCode == KeyCode.Return || SubmitName.submitted == true) { 
			PlayerPrefs.SetString("playername", playerNameSet);
			userHasHitReturn = true;
			newHiScore.SetActive(false);
			submit.SetActive(false);
			nameBox.SetActive(false);
			keyboard.active = false;
			guiText.enabled = false;
			Invoke("GameOverScreen", 1.0f);
		}
		else if (userHasHitReturn == false) {    
			newHiScore.SetActive(true);
			submit.SetActive(true);
			nameBox.SetActive(true);
		}
	}


	void GameOverScreen() {
		gameOver.SetActive(true);
		tryAgainGO.SetActive(true);
		mainMenuGO.SetActive(true);
		hiscore.SetActive (true);
	}

}
