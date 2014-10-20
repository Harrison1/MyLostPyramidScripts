using UnityEngine;
using System.Collections;

public class HiScore5 : MonoBehaviour {

	string hi;
	
	void Start() {
		hi = PlayerPrefs.GetInt("hiscore5").ToString();
		guiText.text = hi;
	}
}
