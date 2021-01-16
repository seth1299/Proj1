using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10;
    private bool timerRunning = true;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI lossText;
    float seconds = 10.0f;
    public GameObject gameController;
    bool gameOver = false;
    private bool victory;

    void Update()
    {
        gameOver = gameController.GetComponent<GameControllerScript>().getGameOver();
        if (timeRemaining > 0 && gameOver == false)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            victory = false;
            timerRunning = false;
        }
        updateTimerText();
    }

    public bool getTimer()
    {
        return !timerRunning;
    }

    public void updateTimerText()
    {
        seconds = Mathf.FloorToInt(timeRemaining);
        if (seconds > 0)
            timerText.text = "Time remaining: " + string.Format("{0}", seconds);
        else
        {
            timerText.text = "Time remaining: 0";
            lossText.text = "You lost, time ran out!";
        }
    }
}