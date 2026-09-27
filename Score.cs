using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;

    public TMP_Text scoreText;

    void Start()
    {
        score = 0;
        UpdateScore();
    }

    public void AddScore(int point)
    {
        score += point;

        UpdateScore();

        Debug.Log(score);
    }

    void UpdateScore()
    {
        scoreText.text = "Score : " + score;
    }
}