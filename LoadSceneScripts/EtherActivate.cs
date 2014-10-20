using UnityEngine;
using System.Collections;

public class EtherActivate : MonoBehaviour {

	public GameObject etherDeActive;
	public GameObject etherActive;
	
	void Start () {
		
		if(PlayerPrefs.GetInt("level3score")>=1)
		{
			etherActive.SetActive(true);
			etherDeActive.SetActive(false);
		}
		else
		{
			etherDeActive.SetActive(true);
			etherActive.SetActive (false);
		}
		
	}
	
}
