using UnityEngine;
using System.Collections;

public class Name2 : MonoBehaviour {

	void Start() {
		guiText.text = PlayerPrefs.GetString("hiname2");
	}
}
