using UnityEngine;
using System.Collections;

public class LoadLevel1 : MonoBehaviour {

	Color colorg = new Color(0.5f, 0.5f, 0.5f, 0.8f);
	Color colorw = new Color(1f, 1f, 1f, 1f);
	
	void OnMouseDown(){
		guiText.color = colorg;
	}
	
	void OnMouseUp(){
		guiText.color = colorw;
		Application.LoadLevel("Level1");
	}
}
