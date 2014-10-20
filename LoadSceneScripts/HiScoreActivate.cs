using UnityEngine;
using System.Collections;

public class HiScoreActivate : MonoBehaviour {

	public GameObject hiscoreDeActive;
	public GameObject hiscoreActive;
	
	void Start () {
		
		if(PlayerPrefs.GetInt("level4score")>=1)
		{
			hiscoreActive.SetActive(true);
			hiscoreDeActive.SetActive(false);
		}
		else
		{
			hiscoreDeActive.SetActive(true);
			hiscoreActive.SetActive (false);
		}
		
	}
	
}
