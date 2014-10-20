using UnityEngine;
using System.Collections;

public class ChoosePyramid : MonoBehaviour {

	public GameObject pyramid1;
	public GameObject pyramid2;

	void Start(){

		if(PlayerPrefs.GetInt("level4score")>=1)
		{
			pyramid2.SetActive(true);
			pyramid1.SetActive(false);
		}
		else
		{
			pyramid1.SetActive(true);
			pyramid2.SetActive (false);
		}
	}
}
	
