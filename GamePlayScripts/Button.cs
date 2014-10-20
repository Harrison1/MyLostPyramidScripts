using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	void OnTouchDown()
	{
		animation.Play("Boom");
	}
}
