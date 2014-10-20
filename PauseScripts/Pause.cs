using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	
	bool isPaused = false;
	public GameObject inputHandler2D;
	public GameObject mainCamera;
	public GameObject blkScreen;
	public GameObject resume;
	public GameObject levelSelect;
	public GameObject mainMenu;
	
	public void OnMouseDown() {

		if(!isPaused){
		isPaused = true;
		inputHandler2D.SetActive(false);
		Time.timeScale = 0.0f;
		mainCamera.audio.Pause();
		blkScreen.SetActive(true);
		resume.SetActive(true);
		levelSelect.SetActive(true);
		mainMenu.SetActive(true);
		
		}

		else if(isPaused){
			isPaused = false;
			inputHandler2D.SetActive(true);
			Time.timeScale = 1.0f;
			mainCamera.audio.Play();
			blkScreen.SetActive(false);
			resume.SetActive(false);
			levelSelect.SetActive(false);
			mainMenu.SetActive(false);
		}
	}
}
