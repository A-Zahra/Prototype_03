using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class buttonPress : MonoBehaviour,IPointerEnterHandler,IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        GameStats.State = "play";
        SceneManager.LoadScene("Game_Level01", LoadSceneMode.Single);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("enter");
    }
}
