using UnityEngine;
using System.Collections;

public class SubmitName : MonoBehaviour {

	Color colorg = new Color(0.5f, 0.5f, 0.5f, 0.8f);
	Color colorw = new Color(1f, 1f, 1f, 1f);

	static public bool submitted;

	void Start(){
		submitted = false;
	}
	
	void OnMouseDown(){
		guiText.color = colorg;
	}
	
	void OnMouseUp(){
		guiText.color = colorw;
		submitted = true;
	}
}
