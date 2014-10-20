using UnityEngine;
using System.Collections;

public class ScorePoint : MonoBehaviour {
	
	void RayCastHit(Collider2D collider){
		if(collider.tag == "Player") {
			Score.AddPoint();
		}
	}
}
