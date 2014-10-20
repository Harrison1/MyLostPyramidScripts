using UnityEngine;
using System.Collections;

public class TriAnimation : MonoBehaviour {
	
	void Start () {
		animation.Play("TopTri");
		StartCoroutine(PlayHealth());
	}

	IEnumerator PlayHealth() {
		yield return new WaitForSeconds(2);
		animation.Play("TopTri2nd");
	}

}
