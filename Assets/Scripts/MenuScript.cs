using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	private GUISkin newSkin;

	void Start()
	{
		newSkin = Resources.Load ("Menu Skin") as GUISkin;
	}

	void OnGUI()
	{
		const int buttonWidth = 600;
		const int buttonHeight = 200;

		GUI.skin = newSkin;

		if (GUI.Button (
			new Rect (Screen.width / 2 - (buttonWidth / 2), 
		         	(2 * Screen.height / 2.2f) - (buttonWidth / 2),
	         		buttonWidth, buttonHeight),
			"Engage")) 
		{
            // Application.LoadLevel("Level1");
            // ButtonClickSound();
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }
	}
}
