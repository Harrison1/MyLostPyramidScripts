using UnityEngine;
using System.Collections;

public class Name4 : MonoBehaviour {

	void Start () {
		guiText.text = PlayerPrefs.GetString("hiname4");
	}
}
