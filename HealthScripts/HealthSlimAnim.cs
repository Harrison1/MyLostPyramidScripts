using UnityEngine;
using System.Collections;

public class HealthSlimAnim : MonoBehaviour {

	public AudioClip healthBreak;
	
	public void PlayHealthBoomSlimAnim() 
	{
		audio.volume = 0.5f;
		audio.PlayOneShot(healthBreak);
		animation.Play("HealthBoomSlim2");
	}
}
