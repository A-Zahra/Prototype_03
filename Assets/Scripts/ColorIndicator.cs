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
    void Update()
    {
        if (GameStats.State == "play" && notStarted ==false)
        {
            InvokeRepeating("colorChange", 1f, 5f);
            notStarted = true;
            //Debug.Log("once");
        }
    }
    private void OnGUI()
    {

        GUIStyle myStyle = new GUIStyle();
        myStyle.normal.textColor = Color.white;
        myStyle.fontSize = 25;
       
        GUI.Label((new Rect(860, 80, 200, 100)), currentColor, myStyle);
        GUI.Label((new Rect(600, 80, 200, 100)), counter, myStyle);
        GUI.Label((new Rect(630, 140, 200, 100)), GameStats.Points.ToString(), myStyle);

    }


    void colorChange() {
        int index = Random.Range(0, 8);
        currentColor = colorsList[index];
        currentMaterial = boxColors[index];
        GetComponent<Renderer>().material = currentMaterial;
    }
}
