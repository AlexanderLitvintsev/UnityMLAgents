using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

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

		// Restart
		if (GUI.Button (
			new Rect (Screen.width / 2 - (buttonWidth / 2), 
		          (2 * Screen.height / 3.6f) - (buttonWidth / 2),
		          buttonWidth, buttonHeight),
			"Retry")) 
		{

            // Button Click Sound
            SoundEffectScript.Instance.MakeButtonClickSound();

            ClearKillCounter();

            // Application.LoadLevel("Level1");
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }

        // Back to the menu
        if (GUI.Button (
			new Rect (Screen.width / 2 - (buttonWidth / 2), 
		          (2 * Screen.height / 2.5f) - (buttonWidth / 2),
		          buttonWidth, buttonHeight),
			"Menu")) 
		{
            // Button Click Sound
            SoundEffectScript.Instance.MakeButtonClickSound();

            ClearKillCounter();

            // Application.LoadLevel("Menu");
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
	}

    void ClearKillCounter()
    {
        // Kills = 0
        GUIScript.gameScore = 0;
    }
}
