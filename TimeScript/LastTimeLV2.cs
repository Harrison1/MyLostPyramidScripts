using UnityEngine;
using System.Collections;

public class LastTimeLV2 : MonoBehaviour {

	public GameObject guiTime;
	
	void Update () {
		guiText.text = guiTime.GetComponent<CountdownClockLV2>().lastTime;
	}
	
}
