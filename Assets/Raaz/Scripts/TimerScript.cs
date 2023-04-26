using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float totalTime = 600.0f; // Total time in seconds (10 minutes)
    private float timeRemaining; // Time remaining in seconds

    public Text timerText; // Text object to display the timer

    void Start()
    {
        timeRemaining = totalTime;
    }

    void Update()
    {
        if (timeRemaining > 0.0f)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
            // Timer has finished
            Debug.Log("Timer finished!");
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60.0f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60.0f);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = timeString;
    }
}
