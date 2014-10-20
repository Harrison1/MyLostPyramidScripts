using UnityEngine;
using System.Collections;

public class DecreaseHealthLV1 : MonoBehaviour {

	public GameObject mainCamera;

	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.tag == "Blue") {
			HealthLV1.HitPoint();
			Boom2D boom2D = collider.transform.GetComponent<Boom2D>();
			CameraShake camShake = mainCamera.transform.GetComponent<CameraShake>();
			collider.enabled = false;
			if(boom2D)
			{
				boom2D.PlayHealthBoomAnim();
				camShake.PlayCameraShakeAnim();
			}
		}
	}
}
