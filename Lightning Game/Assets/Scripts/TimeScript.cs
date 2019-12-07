using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{

    private float maxTime; // in seconds
    public Text EndGameMessage;
    Text timerDisplay;

    private void Start()
    {
        timerDisplay = GetComponent<Text>();
        // allows developers to change stats in Scripts object
        //  in the Hierarchy
        maxTime = TimeManager.timeManagerRef.maxTime;
        
    }

    private void Update()
    {

        maxTime -= Time.deltaTime;

        // Converts the time into string
        string minutes = Mathf.Floor((maxTime % 3600) / 60).ToString("0");
        string seconds = Mathf.Floor(maxTime % 60).ToString("00");

        if (maxTime > 0f)
        {
            if (maxTime < 60f) timerDisplay.color = Color.red; // alerts players they are running out of time
            timerDisplay.text = minutes + ":" + seconds;
        }
        else
        {
            maxTime = 0;
            timerDisplay.color = Color.red;
            timerDisplay.text = "OUT OF TIME";
            EndGameMessage.text = "You Lose!";
            Time.timeScale = 0;
        }

    }

}
