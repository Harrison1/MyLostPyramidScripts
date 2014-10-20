using UnityEngine;
using System.Collections;

public class LoadEarthGreen : MonoBehaviour {

	void OnMouseDown(){
		GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 0.8f);
	}
	
	void OnMouseUp(){
		GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, 1f);
		Application.LoadLevel("Level2");
	}
}
