using UnityEngine;
using System.Collections;

public class LastTimeLV3 : MonoBehaviour {

	public GameObject guiTime;
	
	void Update () {
		guiText.text = guiTime.GetComponent<CountdownClockLV3>().lastTime;
	}
	
}
