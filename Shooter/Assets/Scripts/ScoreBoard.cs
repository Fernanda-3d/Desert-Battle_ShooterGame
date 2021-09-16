using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    int score;
    TMP_Text scoreText;
    public TMP_Text savedScore;

    // Start is called before the first frame update

    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "0";

        savedScore.text = PlayerPrefs.GetInt("score", 0).ToString();
    }
    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease; // = score = score + amountToIncrease;
        scoreText.text = score.ToString();

        PlayerPrefs.SetInt("score", score);
        
    }

}
