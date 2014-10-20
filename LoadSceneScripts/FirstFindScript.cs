using UnityEngine;
using System.Collections;

public class FirstFindScript : MonoBehaviour {

	public GameObject firstFind;
	public static bool firstIsActive;

	void OnMouseDown(){
		if(firstIsActive == false){
			firstIsActive=true;
			firstFind.SetActive (true);
			Invoke ("DeactivateFirst", 4);
			}
	}
	
	void DeactivateFirst(){
		firstFind.SetActive (false);
		firstIsActive = false;
	}
}
