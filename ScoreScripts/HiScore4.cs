using UnityEngine;
using System.Collections;

public class HiScore4 : MonoBehaviour {

	string hi;
	
	void Start() {
		hi = PlayerPrefs.GetInt("hiscore4").ToString();
		guiText.text = hi;
	}
}
