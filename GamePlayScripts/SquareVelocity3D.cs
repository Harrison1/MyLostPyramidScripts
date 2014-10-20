using UnityEngine;
using System.Collections;

public class SquareVelocity3D : MonoBehaviour {

	public float speed = -2f;
	
	void Update () {
		rigidbody.velocity = new Vector2 (0, speed);
	}
}
