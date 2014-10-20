using UnityEngine;
using System.Collections;

public class LastTimeLV1 : MonoBehaviour {
	
	public GameObject guiTime;
	
	void Update () {
		guiText.text = guiTime.GetComponent<CountdownClockLV1>().lastTime;
	}
	
}

