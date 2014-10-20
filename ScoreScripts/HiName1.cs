using UnityEngine;
using System.Collections;

public class HiName1 : MonoBehaviour {
	
	string topName;
	
	void Start() {
		topName = PlayerPrefs.GetString ("hiname1");
		guiText.text = topName;
	}
}

