using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
public class Timer : MonoBehaviour
{
    private float timeLimit = 60.0f;
    private float timerValue;
    // Start is called before the first frame update
    void Start()
    {
        GameStats.gameOver = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameStats.State == "play")
        {
            if (timeLimit >= 0)
            {
                timeLimit = timeLimit - Time.deltaTime;
                timerValue = Mathf.Round(timeLimit * 10.0f) * 0.1f;
            }
            else
            {
                GameStats.gameOver = true;
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            }
            if (GameStats.wrongCapTouched >= 3)
            {
                GameStats.gameOver = true;
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            }
            //Debug.Log(timeLimit);
        }
       

    }
    private void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.normal.textColor = Color.white;
        myStyle.fontSize = Screen.width / 55;
        GUI.Label((new Rect((float)Screen.width / 2.07f, Screen.height / 8, 200, 100)), "Timer", myStyle);
        GUI.Label((new Rect((float)Screen.width / 2.05f, Screen.height / 5, 200, 100)), timerValue.ToString(), myStyle);

    }
}
