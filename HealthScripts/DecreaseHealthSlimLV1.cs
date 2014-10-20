using UnityEngine;
using System.Collections;

public class DecreaseHealthSlimLV1 : MonoBehaviour {

	public GameObject mainCamera;
	public GameObject greenHealthBar;
	public AudioClip glassBreak;
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.tag == "Blue") {
			Boom2D boom2D = collider.transform.GetComponent<Boom2D>();
			collider.enabled = false;
			CameraShake camShake = mainCamera.transform.GetComponent<CameraShake>();
			if(boom2D)
			{
				boom2D.PlayHealthBoomLVCAnim();
				audio.PlayOneShot(glassBreak);
				animation.Play("HealthBoomSlim2");
				camShake.PlayCameraShakeAnim();
				Invoke("DisableHealthCollider", 0.5f);
				Invoke("DestroyGreenHealth", 1.0f);
			}
		}
	}

	void DisableHealthCollider()
	{
		greenHealthBar.collider2D.enabled = false;
	}

	void DestroyGreenHealth() 
	{
		greenHealthBar.SetActive(false);
	}
}
