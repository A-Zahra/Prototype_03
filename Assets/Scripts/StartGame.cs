using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        buttonStyle.fontSize = 26;
        buttonStyle.normal.textColor = Color.green;

        if (GUI.Button( new Rect (50, 400, 150, 20), "Load Game!", buttonStyle))
        {
            GameStats.State = "play";
            SceneManager.LoadScene("Game_Level01", LoadSceneMode.Single);
        }

        GUIStyle myStyle = new GUIStyle();
        myStyle.normal.textColor = Color.white;
        myStyle.fontSize = 20;
        GUI.Label((new Rect(50, 170, 500, 500)), "INSTRUCTIONS " +
            "\n 1. To collect jewels, click on the container cap to open. " +
            "\n 2. Only collect the jewels whose color matches the color displayed on the screen. " +
            "\n 3. You will lose the game if you hit three wrong color caps!" +
            "\n 4. Please play this game in 'Maximize on play' mode." +
            "\n 5. Wait for one round of jewels to fall completely" +
            "\n and then click on the caps for the next round." +
            "\n 6. You have 60 seconds to organize as many jewels as you can.", myStyle);
       
        GUI.Label((new Rect(50, 50, 500, 500)), "Game Story" +
        "\n Hello! I am a jeweler. I bought a set of new jewels yesterday, " +
        "\n and I need to classify them based on their color. " +
        "\n Can you please help me get this done before my first customer comes into the store?", myStyle);

    }
}
