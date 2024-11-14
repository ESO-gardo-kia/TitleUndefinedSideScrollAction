using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public bool isGame;
    [SerializeField] private float currentTime;
    [SerializeField] private float timeLimit;
    [SerializeField] private float currentStartTime;
    [SerializeField] private float startTimeLimit;
    [SerializeField] GameInfomationUi infomationUi;
    void Start()
    {
        isGame = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            isGame = false;
            Debug.Log(isGame);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            isGame = true;
            Debug.Log(isGame);
        }

        if (isGame)
        {
            Timer();
            infomationUi.SetText(currentTime, timeLimit);
        }
    }
    private void Timer()
    {
        if (timeLimit <= currentTime)
        {
            currentTime = timeLimit;
            isGame = false;
        }
        else
        {
            currentTime += Time.deltaTime;
        }
    }

    private void GameOver()
    {
        isGame = false;
    }
}
