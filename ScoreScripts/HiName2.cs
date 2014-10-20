using UnityEngine;
using System.Collections;

public class HiName2 : MonoBehaviour {

	string topName;
	
	void Start() {
		topName = PlayerPrefs.GetString ("hiname2");
		guiText.text = topName;
	}
}
