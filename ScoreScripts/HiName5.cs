using UnityEngine;
using System.Collections;

public class HiName5 : MonoBehaviour {

	string topName;
	
	void Start() {
		topName = PlayerPrefs.GetString ("hiname5");
		guiText.text = topName;
	}
}
