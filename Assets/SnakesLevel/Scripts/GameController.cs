using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private int highScore = 0;
    private int currentScore = 0;

    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI currentScoreText;

    public GameObject ball;

    public void IncrementCurrentScore()
    {
        currentScore++;

        currentScoreText.text = "Score: " + currentScore + " hits";
    }

    public void ScoreByPlayer()
    {
        ball.transform.position = Vector3.zero;
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        if (currentScore <= highScore || highScore == 0)
        {
            highScore = currentScore;

            highScoreText.text = "High Score: " + highScore + " hits";
        }

        currentScore = 0;

        currentScoreText.text = "Score: " + currentScore + " hits";
    }
}
