using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    void Update()
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
        myStyle.fontSize = 25;
        GUI.Label((new Rect(730, 81, 200, 100)), "Timer", myStyle);
        GUI.Label((new Rect(730, 140, 200, 100)), timerValue.ToString(), myStyle);


    }
}
