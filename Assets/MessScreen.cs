using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MessScreen : MonoBehaviour
{
    public TMP_Text Loss;
    public TMP_Text Win;
    public TMP_Text TextStart;
    public TMP_Text TextFirst;
    public Button StartGame;
    public Movement Player;
    public Button First;
    public bool IsFirst = true;

    public void ScreenWin()
    {
        Player.IsStart = false;
        Win.gameObject.SetActive(true);
        TextStart.gameObject.SetActive(true);
        StartGame.gameObject.SetActive(true);
        StartGame.onClick.AddListener(TaskOnClick);
    }

    public void ScreenLoss()
    {
        Player.IsStart = false;
        Loss.gameObject.SetActive(true);
        TextStart.gameObject.SetActive(true);
        StartGame.gameObject.SetActive(true);
        StartGame.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick() 
    {
        SceneManager.LoadScene("Prototype 4");
        Player.IsStart = true;
	}

    public void SetActiveFalse()
    {
        Loss.gameObject.SetActive(false);
        TextStart.gameObject.SetActive(false);
        StartGame.gameObject.SetActive(false);
        Win.gameObject.SetActive(false);
        TextFirst.gameObject.SetActive(false);
        First.gameObject.SetActive(false);
    }

    public void SetActiveFirst()
    {
        if(IsFirst){
            Player.IsStart = false;
            IsFirst = false;
            TextFirst.gameObject.SetActive(true);
            First.gameObject.SetActive(true);
            First.onClick.AddListener(TaskOnClickFirst);
        }
    }

    public void TaskOnClickFirst() 
    {
        Player.IsStart = true;
        SetActiveFalse();
	}
}
