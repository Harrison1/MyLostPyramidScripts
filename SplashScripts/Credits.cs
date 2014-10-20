using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {

	public GameObject mainCamera;
	public float speed = 0.7f;
	public float restartTime = 126f;

	void Update()
	{
		if(this.transform.position.y > -68)
		{
			mainCamera.transform.Translate(Vector3.down * Time.deltaTime * speed);
		} else if (this.transform.position.y <= -68) {
			mainCamera.transform.Translate(Vector3.down * Time.deltaTime * 0);
		}
		
		Invoke ("restartCredits", restartTime);

	}
	
	void restartCredits()
	{
		Application.LoadLevel("MainMenu");
	}
}
