using UnityEngine;
using System.Collections;

public class SquareVelocity : MonoBehaviour {

	public float speed = -2f;

	void Update () {
		rigidbody2D.velocity = new Vector2 (0, speed);
	}
}
