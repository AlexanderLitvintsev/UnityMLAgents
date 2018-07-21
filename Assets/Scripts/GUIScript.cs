using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIScript : MonoBehaviour {

    private GUISkin newSkin;

    public static int gameScore = 0;


    // Use this for initialization
    void Start () {

        newSkin = Resources.Load("GUI Skin") as GUISkin;

    }

    void OnGUI()
    {


        string score = "Kill : " + gameScore.ToString();

        const int buttonWidth = 120;
        const int buttonHeight = 60;

        GUI.Label(new Rect(10, 10, 100, 20), score.ToString());

        /*
=======
        /*
        const int buttonWidth = 120;
        const int buttonHeight = 60;

>>>>>>> b35f81915e3268583a0b613ad82657de6ab4dfe5
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
        */

    }

}
