using UnityEngine;
using System.Collections;

public class HiScore3 : MonoBehaviour {

	string hi;
	
	void Start() {
		hi = PlayerPrefs.GetInt("hiscore3").ToString();
		guiText.text = hi;
	}
}
