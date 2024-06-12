using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHighScore : MonoBehaviour
{
    [SerializeField] private Text ScoreText;
    private string highScoreText = "Best Score : {0} : {1}";

    void Start()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);

        if(highScore > 0)
        {
            string playerNameHighScore = PlayerPrefs.GetString("PlayerScore", "");
            ScoreText.text = String.Format(highScoreText, playerNameHighScore, highScore);
            ScoreText.gameObject.SetActive(true);
        }
        else
        {
            ScoreText.gameObject.SetActive(false);
        }
    }
}
