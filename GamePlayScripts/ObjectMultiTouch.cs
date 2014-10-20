using UnityEngine;
using System.Collections;

public class ObjectMultiTouch : MonoBehaviour {

	public LayerMask touchInputMask;

	void Update () 
	{

		foreach (Touch touch in Input.touches) {

			Ray ray = Camera.main.ScreenPointToRay(touch.position);	
			RaycastHit hit;

			if(Physics.Raycast(ray, out hit, touchInputMask))
			{

				GameObject recipient = hit.transform.gameObject;

				if(touch.phase == TouchPhase.Began){
					recipient.SendMessage("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);

				if(touch.phase == TouchPhase.Ended){
					recipient.SendMessage("OnTouchEnded", hit.point, SendMessageOptions.DontRequireReceiver);

				if(touch.phase == TouchPhase.Moved){
					recipient.SendMessage("OnTouchMoved", hit.point, SendMessageOptions.DontRequireReceiver);
				}
				
			
			}
		}
	}
}
	}}

		/* RaycastHit hit = new RaycastHit();
		for (int i = 0; i < Input.touchCount; i++) {
			if (Input.GetTouch(i).phase.Equals(TouchPhase.Began)) {
				// Construct a ray from the current touch coordinates
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
				if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity)) {
					//hit.transform.gameObject.SendMessage("OnMouseDown");

					Debug.Log("TouchMe");
					Boom boom = hit.transform.GetComponent<Boom>();
					if(boom)
					{
						boom.PlayBoomAnim();
					}
				}

				/*if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity)) {
					//Destroy(this.gameObject);
					//hit.transform.gameObject.SendMessage("OnMouseDown");
					Debug.Log("TouchMe");
					Boom boom = hit.transform.GetComponent<Boom>();
					if(boom)
					{
						boom.PlayBoomAnim();
					}
				}*/
			



		/*	if(Input.GetMouseButton(0))
		{
			//Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//RaycastHit2D rayCastHit;
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			
			if(hit)
			{
				Debug.Log("Mouse Click");
				Boom2D boom2D = hit.transform.GetComponent<Boom2D>();
				if(boom2D)
				{
					boom2D.PlayBoomAnim();
				}
			}
		} */
		
	/*	if(Input.touches.Length <= 0)
		{
			//Excute nothing since length is less than 0
		}
		else
		{
			for(int i = 0; i < Input.touchCount; i++){
				RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
				
				if(this.gameObject.OnMouseDown(Input.GetTouch(i).position))
				{
					if(Input.GetTouch(i).phase = TouchPhase.Began){
					Debug.Log("Touch here");
					Boom2D boom2D = hit.transform.GetComponent<Boom2D>();
					if(boom2D)
					{
						boom2D.PlayBoomAnim();
					}
					}
				}
			}
		}
	} */






