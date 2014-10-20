using UnityEngine;
using System.Collections;

public class LastTime : MonoBehaviour {

	public GameObject guiTime;

	void Update () {
		guiText.text = guiTime.GetComponent<CountdownClock>().lastTime;
	}

}
