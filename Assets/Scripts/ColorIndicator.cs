using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
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
        colorsList[0] = "red";
        colorsList[1] = "purple";
        colorsList[2]= "pink";
        colorsList[3] = "orange";
        colorsList[4] = "green";
        colorsList[5] = "gray";
        colorsList[6] = "blue";
        colorsList[7] = "yellow";
        currentMaterial = boxColors[0];
        GameStats.wrongCapTouched = 0;
 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameStats.State == "play" && notStarted ==false)
        {
            InvokeRepeating("colorChange", 1f, 5f);
            notStarted = true;
        }
    }
    private void OnGUI()
    {

        GUIStyle myStyle = new GUIStyle();
        myStyle.normal.textColor = Color.white;
        myStyle.fontSize = Screen.width / 55;
       
        GUI.Label((new Rect((float)Screen.width / 1.75f , Screen.height / 8, 200, 100)), currentColor, myStyle);
        GUI.Label((new Rect((float)Screen.width / 2.6f, Screen.height / 8, 200, 100)), counter, myStyle);
        GUI.Label((new Rect((float)Screen.width / 2.5f, Screen.height / 5, 200, 100)), GameStats.Points.ToString(), myStyle);

    }


    void colorChange() {
        int index = GameStats.colorSwatch;
        currentColor = colorsList[index];
        currentMaterial = boxColors[index];
        GetComponent<Renderer>().material = currentMaterial;
        transform.GetChild(0).GetComponent<TextMesh>().text = index.ToString();
    }
}
