using UnityEngine;
using System.Collections;

public class SquareDestroy : MonoBehaviour {

	void OnEnable()
	{
		Invoke ("Destroy", 14f);
	}

	void Destroy()
	{
		collider2D.enabled = true;
		gameObject.SetActive(false);
	}

	void OnDisable()
	{
		CancelInvoke();
	}
}
