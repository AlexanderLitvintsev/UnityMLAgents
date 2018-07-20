using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIScript : MonoBehaviour {

    private GUISkin newSkin;

    // Use this for initialization
    void Start () {

        newSkin = Resources.Load("GUI Skin") as GUISkin;

    }

    void OnGUI()
    {

        const int buttonWidth = 120;
        const int buttonHeight = 60;

        // Restart
        if (GUI.Button(
            new Rect(Screen.width / 2 - (buttonWidth / 2),
                  (2 * Screen.height / 4) - (buttonWidth / 2),
                  buttonWidth, buttonHeight),
            "Up"))
        {
            // Application.LoadLevel("Level1");
            Input.GetAxis("Horizontal");
        }

    }

}
