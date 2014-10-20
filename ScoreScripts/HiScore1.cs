using UnityEngine;
using System.Collections;

public class HiScore1 : MonoBehaviour {

	string hi;
	
	void Start() {
		hi = PlayerPrefs.GetInt("hiscore1").ToString();
		guiText.text = hi;
	}
}
