using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{
    TextMeshProUGUI scoretext;
    int score;

    private void Awake()
    {
        scoretext = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        score = 0;
        scoretext.SetText("SCORE: " + score);
    }

    public void IncreaseScore(int scoreIncrease)
    {
        score += scoreIncrease;
        scoretext.text = "SCORE: " + score;
    }
}
