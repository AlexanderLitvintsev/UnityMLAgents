using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIScript : MonoBehaviour {

    private GUISkin TextSkin;
    private Color TextColor = Color.white;
    public static int gameScore = 0;


    // Use this for initialization
    void Start () {

        TextSkin = Resources.Load("Menu Skin") as GUISkin;

    }

    void OnGUI()
    {
        // GUIUtility.ScaleAroundPivot(new Vector2(k, k), new Vector2(Screen.width * 0.5f, Screen.height * 0.5f));
        GUI.skin = TextSkin;
        string score = "Kills: " + gameScore.ToString();

        GUI.Label(new Rect(50, 50, 600, 240), score.ToString());


    }

}
