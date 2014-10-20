using UnityEngine;
using System.Collections;

public class Name5 : MonoBehaviour {

	void Start () {
		guiText.text = PlayerPrefs.GetString("hiname5");
	}
}
