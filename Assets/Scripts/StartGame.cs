using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;


public class StartGame : MonoBehaviour
{
    public string instructions = "INSTRUCTIONS \n 1. Click on the container cap to open. \n 2. Only collect the jewels that their color matches the color displayed on the screen. \n 3. If you pick 3 wrong color, you will lose the game!";
   
    public void Start()
    {
        GameStats.State = "intro";
       
    }
    // Update is called once per frame
    private void OnGUI()
    {
        GUIStyle buttonStyle = new GUIStyle();
        buttonStyle.fontSize = Screen.width / 44;
        buttonStyle.normal.textColor = Color.green;


        GUIStyle myStyle = new GUIStyle();
        myStyle.normal.textColor = Color.white;
        myStyle.fontSize = Screen.width / 70;
        GUI.Label((new Rect(Screen.width/25, Screen.height/4, 500, 500)), "INSTRUCTIONS " +
            "\n 1. To collect jewels, click on the container cap to open. " +
            "\n 2. Only collect the jewels whose color matches the color displayed on the screen. " +
            "\n 3. You will lose the game if you hit three wrong color caps!" +
            "\n 4. Please play this game in 'Maximize on play' mode." +
            "\n 5. Wait for one round of jewels to fall completely" +
            "\n and then click on the caps for the next round." +
            "\n 6. You have 60 seconds to organize as many jewels as you can." +
            "\n 7. If you are color blind, ignore the colors and match " +
            "\n the numbers with the number that is displayed on the screen.", myStyle);

        GUI.Label((new Rect(Screen.width / 25, (float)Screen.height / 1.58f, 500, 500)), "HINT" +
         "\n Always start with the containers that are further! ", myStyle);

        GUI.Label((new Rect(Screen.width / 25, Screen.height / 14, 500, 500)), "Game Story" +
        "\n Hello! I am a jeweler. I bought a set of new jewels yesterday, " +
        "\n and I need to classify them based on their color. " +
        "\n Can you please help me get this done before my first customer comes into the store?", myStyle);

        Color pink = new Color(250f, 0.5f, 0.5f);
        Color purple = new Color(0.5f, 0.5f, 250f);
        Color orange = new Color(250f, 0.5f, 0.1f);
       
        GUI.Label(new Rect((float)Screen.width / 1.54f, Screen.height /11, 150, 20), "Jewels Color Guide", myStyle);

        /*
        #if UNITY_EDITOR
        EditorGUI.DrawRect(new Rect((float)Screen.width / 1.18f, Screen.height / 5, (float)Screen.width / 22, (float)Screen.width / 22), Color.red);
        #endif
        GUI.Label(new Rect((float)Screen.width / 1.18f, Screen.height / 3, 150, 20), "Red", myStyle);

        #if UNITY_EDITOR
        EditorGUI.DrawRect(new Rect((float)Screen.width / 1.28f, (float)Screen.height / 2.5f, (float)Screen.width / 22, (float)Screen.width / 22), purple);
        #endif
        GUI.Label(new Rect((float)Screen.width / 1.28f, (float)Screen.height / 1.87f, 150, 20), "purple", myStyle);

        #if UNITY_EDITOR
        EditorGUI.DrawRect(new Rect((float)Screen.width / 1.54f, (float)Screen.height / 2.5f, (float)Screen.width / 22, (float)Screen.width / 22), pink);
        #endif
        GUI.Label(new Rect((float)Screen.width / 1.54f, (float)Screen.height / 1.87f, 150, 20), "pink", myStyle);

        #if UNITY_EDITOR
        EditorGUI.DrawRect(new Rect((float)Screen.width / 1.18f, (float)Screen.height / 2.5f, (float)Screen.width / 22, (float)Screen.width / 22), orange);
        #endif
        GUI.Label(new Rect((float)Screen.width / 1.18f, (float)Screen.height / 1.87f, 150, 20), "orange", myStyle);

        #if UNITY_EDITOR
        EditorGUI.DrawRect(new Rect((float)Screen.width / 1.54f, Screen.height / 5, (float)Screen.width / 22, (float)Screen.width / 22), Color.green);
        #endif
        GUI.Label(new Rect((float)Screen.width / 1.54f, Screen.height / 3, 150, 20), "Green", myStyle);

        #if UNITY_EDITOR
        EditorGUI.DrawRect(new Rect((float)Screen.width / 1.4f, (float)Screen.height / 2.5f, (float)Screen.width / 22, (float)Screen.width / 22), Color.gray);
        #endif
        GUI.Label(new Rect((float)Screen.width / 1.4f, (float)Screen.height / 1.87f, 150, 20), "gray", myStyle);

        #if UNITY_EDITOR
        EditorGUI.DrawRect(new Rect((float)Screen.width / 1.4f, Screen.height / 5, (float)Screen.width / 22, (float)Screen.width / 22), Color.cyan);
        #endif  
        GUI.Label(new Rect((float)Screen.width / 1.4f, Screen.height / 3, 150, 20), "Blue", myStyle);

        #if UNITY_EDITOR
        EditorGUI.DrawRect(new Rect((float)Screen.width / 1.28f, Screen.height / 5, (float)Screen.width / 22, (float)Screen.width / 22), Color.yellow);
        #endif
        GUI.Label(new Rect((float)Screen.width / 1.28f, Screen.height / 3, 150, 20), "Yellow", myStyle);

        */



    }
}
