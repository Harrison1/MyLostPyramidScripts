using UnityEngine;
using System.Collections;

public class EarthActivate : MonoBehaviour {

	public GameObject earthDeActive;
	public GameObject earthActive;
	
	void Start () {

		if(PlayerPrefs.GetInt("level1score")>=1)
		{
			earthActive.SetActive(true);
			earthDeActive.SetActive(false);
		}
		else
		{
			earthDeActive.SetActive(true);
			earthActive.SetActive (false);
		}
	
	}

}
