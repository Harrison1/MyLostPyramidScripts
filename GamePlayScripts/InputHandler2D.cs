using UnityEngine;
using System.Collections;

public class InputHandler2D : MonoBehaviour {
	
	void Update () 
	{
		if(Input.GetMouseButton(0))
		{
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

			if(hit)
			{
				Score.AddPoint();
				hit.collider.enabled = false;
				Boom2D boom2D = hit.transform.GetComponent<Boom2D>();
				if(boom2D)
				{
					boom2D.PlayBoomAnim();
				}
			}

		}
	}
} 



