using UnityEngine;
using System.Collections;

public class Name1 : MonoBehaviour {

	void Start () {
		guiText.text = PlayerPrefs.GetString("hiname1");
	}
}
