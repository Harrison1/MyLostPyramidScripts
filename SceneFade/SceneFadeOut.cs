using UnityEngine;
using System.Collections;

public class SceneFadeOut : MonoBehaviour {

	public float fadeSpeed = 0.5f;          // Speed that the screen fades to and from black.
	
	
	//private bool sceneEnd = true;      // Whether or not the scene is still fading in.

	void Awake ()
	{
		// Set the texture so that it is the the size of the screen and covers it.
		guiTexture.pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
		guiTexture.color = Color.clear;
	}
	
	void Update(){
		if(guiTexture.enabled == true)
			EndScene ();
	}

	public void FadeToWhite ()
	{
		// Lerp the colour of the texture between itself and black.
		guiTexture.color = Color.Lerp(guiTexture.color, Color.white, fadeSpeed * Time.deltaTime);
	}

	
	
	public void EndScene ()
	{
		// Make sure the texture is enabled.
		guiTexture.enabled = true;
		
		// Start fading towards black.
		FadeToWhite();
		
		// If the screen is almost black...
		if(guiTexture.color.a >= 0.95f)
			// ... reload the level.
			guiTexture.color = Color.white;
	}
}
