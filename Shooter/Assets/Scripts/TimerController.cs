using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TimerController : MonoBehaviour
{
    public static TimerController instance; //easy way to allow other scripts to call functions

    public Text timeCounter; //reference in the UI
    
    public Text finalText;
    private TimeSpan timePlaying; // System method to config time 00:00 ...
    private bool timerGoing;

    private float elapsedTime; 

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        timeCounter.text = "Time: 00:00.00";
        finalText.text = "00:00.00";
        timerGoing = true;
    }

    public void BeginTimer()
    {
        timerGoing = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        timerGoing = false;    
        

    }
   

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime; // get the 0 time and add the time from the previous frame to the current frame
            timePlaying = TimeSpan.FromSeconds(elapsedTime); //convert float to time - from the System 
            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff"); 
            timeCounter.text = timePlayingStr; 
            finalText.text = timePlayingStr; 

            yield return null; //it's going to come back to the beggining of the coroutine
        }
    }
}
