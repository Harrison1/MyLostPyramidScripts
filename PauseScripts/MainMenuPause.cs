using UnityEngine;
using System.Collections;

public class MainMenuPause : MonoBehaviour {
	
	Color colorg = new Color(0.5f, 0.5f, 0.5f, 0.8f);
	Color colorw = new Color(1f, 1f, 1f, 1f);
	
	void OnMouseDown(){
		guiText.color = colorg;
	}
	
	void OnMouseUp(){
		guiText.color = colorw;
		Time.timeScale = 1.0f;
		Application.LoadLevel("MainMenu");
	}
}
