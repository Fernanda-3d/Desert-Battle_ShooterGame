using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class timer : MonoBehaviour
{
   public TMP_Text timerText;
   public TMP_Text savedTime;
   float startTime;
    void Start()
    {
        startTime = Time.time;
        savedTime.text = PlayerPrefs.GetFloat("Time", 0).ToString();
        

       

    
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60 ).ToString("f2");

        timerText.text = minutes + ":" + seconds;
        

        PlayerPrefs.SetFloat("Time", t);
    }
}
