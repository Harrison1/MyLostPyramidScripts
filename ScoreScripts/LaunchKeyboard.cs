using UnityEngine;
using System.Collections;

public class LaunchKeyboard : MonoBehaviour {
	

	void OnMouseDown() 
	{
		TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, true, true);
		TouchScreenKeyboard.hideInput = true;
	}

}