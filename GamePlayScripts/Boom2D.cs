using UnityEngine;
using System.Collections;

public class Boom2D : MonoBehaviour {

	public AudioClip[] SmashClips;

	public Quaternion originalRotationValue; // declare this as a Quaternion
	float rotationResetSpeed = 1000.0f;
	
	void Start () {
		originalRotationValue = transform.rotation; // save the initial rotation
	}

	public void PlayBoomAnim() 
	{
		audio.volume = 0.5f;
		audio.PlayOneShot(SmashClips[Random.Range(0, SmashClips.Length)]);
		animation.Play("Boom");
	}

	public void PlayHealthBoomAnim()
	{
		audio.volume = 0.5f;
		animation.Play("HealthBoom");
	}

	public void PlayHealthBoomLVCAnim()
	{
		transform.rotation = Quaternion.Slerp(transform.rotation, originalRotationValue, Time.time * rotationResetSpeed); 
		audio.volume = 0.5f;
		animation.Play("HealthBoomLVC1");
	}
}

