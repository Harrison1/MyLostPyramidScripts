using UnityEngine;
using System.Collections;

public class HiScore2 : MonoBehaviour {

	string hi;
	
	void Start() {
		hi = PlayerPrefs.GetInt("hiscore2").ToString();
		guiText.text = hi;
	}
}