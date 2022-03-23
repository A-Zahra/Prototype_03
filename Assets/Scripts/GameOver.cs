using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        myStyle.fontSize = 26;

        GUIStyle buttonStyle = new GUIStyle();
        buttonStyle.fontSize = (int)(40.0f * ((float)Screen.width / (float)nativeSize.x)); ;
        buttonStyle.normal.textColor = Color.yellow;

        GUI.Label(new Rect(400, 220, 150, 20), "Congratulations!", buttonStyle);
        GUI.Label((new Rect(570, 370, 200, 100)), counter, myStyle);
        GUI.Label((new Rect(910, 370, 200, 100)), GameStats.Points.ToString(), myStyle);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
