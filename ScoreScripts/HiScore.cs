using UnityEngine;
using System.Collections;

public class HiScore : MonoBehaviour {

	string topName;
	string hi;

	void Update () {
		hi = PlayerPrefs.GetInt("hiscore1").ToString();
		topName = PlayerPrefs.GetString ("hiname1");
		guiText.text = topName + "   " + hi;
	}
}
