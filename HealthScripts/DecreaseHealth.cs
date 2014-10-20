using UnityEngine;
using System.Collections;

public class DecreaseHealth : MonoBehaviour {

		void OnTriggerEnter2D(Collider2D collider)
		{
			if(collider.tag == "Blue") {
				Health.HitPoint();
		}
	}
}
