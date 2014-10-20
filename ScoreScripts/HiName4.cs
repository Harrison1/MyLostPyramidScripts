using UnityEngine;
using System.Collections;

public class HiName4 : MonoBehaviour {

	string topName;
	
	void Start() {
		topName = PlayerPrefs.GetString ("hiname4");
		guiText.text = topName;
	}
}
