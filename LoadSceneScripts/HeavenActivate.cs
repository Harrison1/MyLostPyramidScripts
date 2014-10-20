using UnityEngine;
using System.Collections;

public class HeavenActivate : MonoBehaviour {

	public GameObject heavenDeActive;
	public GameObject heavenActive;
	
	void Start () {
		
		if(PlayerPrefs.GetInt("level2score")>=1)
		{
			heavenActive.SetActive(true);
			heavenDeActive.SetActive(false);
		}
		else
		{
			heavenDeActive.SetActive(true);
			heavenActive.SetActive (false);
		}
		
	}
	
}
