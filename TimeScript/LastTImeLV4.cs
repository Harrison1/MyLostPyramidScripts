using UnityEngine;
using System.Collections;

public class LastTImeLV4 : MonoBehaviour {

	public GameObject guiTime;
	
	void Update () {
		guiText.text = guiTime.GetComponent<CountdownClockLV4>().lastTime;
	}
	
}
