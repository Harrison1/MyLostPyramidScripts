using UnityEngine;
using System.Collections;

public class SquareVelocityLVC : MonoBehaviour {

	public float speed;

	void Start() {
		speed = -2.0f;
	}

	void Update () {
		rigidbody2D.velocity = new Vector2 (0, speed);
	}

	void FixedUpdate() {

		if (Score.scoreb < 1000) {
			speed = -2.0f;		
		} else if(Score.scoreb >= 1000 && Score.scoreb < 1999){
			speed = -2.5f;
		} else if(Score.scoreb >= 2000 && Score.scoreb < 2999) {
			speed = -3.5f;
		} else if(Score.scoreb >= 3000  && Score.scoreb < 3999) {
			speed = -4.5f;
		} else if(Score.scoreb >= 4000  && Score.scoreb < 4999) {
			speed = -5.5f;
		} else if(Score.scoreb >= 5000) {
			speed = -7.0f;
		}
	}
}

