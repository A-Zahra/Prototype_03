using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GameOver : MonoBehaviour
{
    public string counter = "Number of organized jewels:";
    Vector2 nativeSize = new Vector2(640, 480);
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GameStats.Points);
    }
    private void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.normal.textColor = Color.white;
        myStyle.fontSize = Screen.width / 55;

        GUIStyle buttonStyle = new GUIStyle();
        buttonStyle.fontSize = Screen.width / 15;
        buttonStyle.normal.textColor = Color.yellow;

        GUI.Label(new Rect((float)Screen.width / 3.7f, (float)Screen.height/ 3.5f, 150, 20), "Congratulations!", buttonStyle);
        GUI.Label((new Rect((float)Screen.width / 2.6f, (float)Screen.height / 1.9f, 200, 100)), counter, myStyle);
        GUI.Label((new Rect((float)Screen.width / 1.6f, (float)Screen.height / 1.9f, 200, 100)), GameStats.Points.ToString(), myStyle);

    }

}
