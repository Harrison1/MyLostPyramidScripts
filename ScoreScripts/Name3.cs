using UnityEngine;
using System.Collections;

public class Name3 : MonoBehaviour {

	void Start () {
		guiText.text = PlayerPrefs.GetString("hiname3");
	}
}
