using UnityEngine;
using System.Collections;

public class HiScorePageActivate : MonoBehaviour {
	
	public GameObject hiscorePDeActive;
	public GameObject hiscorePActive;
	
	void Start () {
		
		if(PlayerPrefs.GetInt("level4score")>=1)
		{
			hiscorePActive.SetActive(true);
			hiscorePDeActive.SetActive(false);
		}
		else
		{
			hiscorePDeActive.SetActive(true);
			hiscorePActive.SetActive (false);
		}
		
	}
	
}
