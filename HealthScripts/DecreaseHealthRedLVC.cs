using UnityEngine;
using System.Collections;

public class DecreaseHealthRedLVC : MonoBehaviour {

	public GameObject mainCamera;
	public GameObject greenHealthBar;
	public AudioClip glassBreak;
	
	public GameObject inputHandler2D;
	public GameObject pauseScreenGO;
	public GameObject tryAgainGO;
	public GameObject mainMenuGO;
	public GameObject pauseButton;
	public GameObject gameOver;
	public GameObject hiscore;
	public GameObject nameInput;
	public GameObject hellMusic;
	public GameObject earthMusic;
	public GameObject heavenMusic;
	public GameObject etherMusic;
	public AudioClip alone;
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.tag == "Blue") {
			Boom2D boom2D = collider.transform.GetComponent<Boom2D>();
			collider.enabled = false;
			CameraShake camShake = mainCamera.transform.GetComponent<CameraShake>();
			if(boom2D)
			{
				boom2D.PlayHealthBoomLVCAnim();
				audio.PlayOneShot(glassBreak);
				animation.Play("HealthBoomSlim2");
				camShake.PlayCameraShakeAnim();
				
				inputHandler2D.SetActive(false);
				pauseButton.SetActive(false);
				pauseScreenGO.SetActive(true);
				mainCamera.audio.Stop();
				hellMusic.SetActive(false);
				earthMusic.SetActive(false);
				heavenMusic.SetActive(false);
				etherMusic.SetActive(false);
				audio.PlayOneShot(alone);
				
				Invoke("DisableHealthCollider", 0.5f);

					if(Score.scoreb > PlayerPrefs.GetInt("hiscore5")) {
						nameInput.SetActive(true);
					}
					else {	
						Invoke("GameOverScreen", 1.0f);
					}
			}
		}
	}
	
	void DisableHealthCollider()
	{
		greenHealthBar.collider2D.enabled = false;
	}
	
	void DestroyGreenHealth() 
	{
		greenHealthBar.SetActive(false);
	}
	
	void GameOverScreen() {
		gameOver.SetActive(true);
		tryAgainGO.SetActive(true);
		mainMenuGO.SetActive(true);
		hiscore.SetActive (true);
	}
}