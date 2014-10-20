using UnityEngine;
using System.Collections;

public class HiName3 : MonoBehaviour {

	string topName;
	
	void Start() {
		topName = PlayerPrefs.GetString ("hiname3");
		guiText.text = topName;
	}
}
