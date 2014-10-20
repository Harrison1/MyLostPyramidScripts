using UnityEngine;
using System.Collections;

public class CreditsFingerScroll : MonoBehaviour {

	public float dragSpeed = 0.5f;
	private Vector3 dragOrigin;
	
	public bool cameraDragging = true;
	
	public int outerLeft = 0;
	public int outerRight = 0;
	public int outerTop = 0;
	public int outerBottom = -68;
	
	
	void Update()
	{
		
		Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		
		float left = Screen.width * 0.2f;
		float right = Screen.width - (Screen.width * 0.2f);
		
		if(mousePosition.y < left)
		{
			cameraDragging = true;
		}
		else if(mousePosition.y > right)
		{
			cameraDragging = true;
		}

		
		if (cameraDragging) {
			
			if (Input.GetMouseButtonDown(0))
			{
				dragOrigin = Input.mousePosition;
				return;
			}
			
			if (!Input.GetMouseButton(0)) return;
			
			Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
			Vector3 move = new Vector3(0, pos.y * dragSpeed, 0);
			
			if (move.y > 0f)
			{
				if(this.transform.position.y < outerTop)
				{
					transform.Translate(move, Space.World);
				}
			}
			else{
				if(this.transform.position.y > outerBottom)
				{
					transform.Translate(move, Space.World);
				}
			}
		}
	}
	
	
}