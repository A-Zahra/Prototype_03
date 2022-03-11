using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIndicator : MonoBehaviour
{
    public string[] colorsList = new string[8];
    public string currentColor = "red";
    public string counter = "Counter";
    public Material[] boxColors = new Material[8];
    public Material currentMaterial;
    private bool notStarted = false;

    // Start is called before the first frame update
    void Start()
    {

        GameStats.State = "intro";
        colorsList[0] = "red";
        colorsList[1] = "purple";
        colorsList[2]= "pink";
        colorsList[3] = "orange";
        colorsList[4] = "green";
        colorsList[5] = "gray";
        colorsList[6] = "blue";
        colorsList[7] = "yellow";
        currentMaterial = boxColors[0];
       
 
    }

    // Update is called once per frame
    void Update()
    {
        if (GameStats.State == "play" && notStarted ==false)
        {
            InvokeRepeating("colorChange", 1f, 4f);
            notStarted = true;
            //Debug.Log("once");
        }
    }
    private void OnGUI()
    {

        GUIStyle myStyle = new GUIStyle();
        myStyle.normal.textColor = Color.white;
        myStyle.fontSize = 16;
       
        GUI.Label((new Rect(575, 50, 200, 100)), currentColor, myStyle);
        GUI.Label((new Rect(500, 50, 200, 100)), counter, myStyle);
        GUI.Label((new Rect(520, 110, 200, 100)), GameStats.Points.ToString(), myStyle);

        //GUIStyle buttonStyle = new GUIStyle();
        //buttonStyle.fontSize = 26;
        //RectOffset bdr;
        // bdr = GUI.skin.button.border;
        //bdr.left = 10;
        //bdr.right = 10;
        //bdr.top = 10;
        //bdr.bottom = 10;
        //Debug.Log("Left: " + bdr.left + " Right: " + bdr.right);
        //Debug.Log("Top: " + bdr.top + " Bottom: " + bdr.bottom);
        //buttonStyle.border = bdr;
       // buttonStyle.normal.background = new Color(1.0f, 1.0f, 1.0f, 0.1f);
        if (GUI.Button(new Rect(20, 20, 100, 50), "Start!"))
            GameStats.State = "play";

    }


    void colorChange() {
        int index = Random.Range(0, 8);
        currentColor = colorsList[index];
        currentMaterial = boxColors[index];
        GetComponent<Renderer>().material = currentMaterial;
       // Debug.Log("Testing color");
    }
}
