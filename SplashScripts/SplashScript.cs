using UnityEngine;
using System.Collections;

public class SplashScript : MonoBehaviour {

	public GameObject smob;
	public GameObject squirrelsLogo;

	void Start() {
		Invoke ("Splash", 3.0f);
		Invoke ("LoadMain", 6.0f);
	}

	void Splash(){
		smob.SetActive (false);
		squirrelsLogo.SetActive (true);
	}

	void LoadMain() {
		Application.LoadLevel ("MainMenu");
	}

}
