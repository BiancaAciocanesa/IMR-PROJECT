using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class SnakeGameController : MonoBehaviour
{
    public GameObject key1, key2, key3, key4, key5;
    public TextMeshProUGUI youWinText, tryAgainText, gameOverText, timerText;
    public float timerSeconds;
    private float currentSeconds;
    private bool isRunning = true;

    private void Start()
    {
        GameObject[] keys = new GameObject[5] { key1, key2, key3, key4, key5 };
        var goodKey = keys[UnityEngine.Random.Range(0,5)];
        goodKey.tag = "GoodKey";
        foreach (var key in keys)
        {
            if (key != goodKey)
            {
                key.tag = "BadKey";
            }
        }
        currentSeconds = timerSeconds;
        timerText.text = currentSeconds.ToString("0.00");
    }

    private void Update()
    {
        timerText.text = currentSeconds.ToString("0.00");

        if (currentSeconds < 0 && isRunning)
        {
            isRunning = false;
            currentSeconds = 0.00f;
            GameOver();
        }
        else if (isRunning)
        {
            currentSeconds -= Time.deltaTime;
        }
    }

    public void YouWon()
    {
        isRunning = false;
        timerText.gameObject.SetActive(false);
        youWinText.gameObject.SetActive(true);
        StartCoroutine(DelayYouWonText());
    }

    public void TryAgain()
    {
        tryAgainText.gameObject.SetActive(true);
        StartCoroutine(DelayTryAgainText());
    }

    public void GameOver()
    {
        timerText.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(true);
        StartCoroutine(DelayGameOverText());
    }

    IEnumerator DelayYouWonText()
    {
        yield return new WaitForSeconds(2);
        youWinText.gameObject.SetActive(false);
        EditorApplication.isPlaying = false;
    }

    IEnumerator DelayTryAgainText()
    {
        yield return new WaitForSeconds(2);
        tryAgainText.gameObject.SetActive(false);
    }

    IEnumerator DelayGameOverText()
    {
        yield return new WaitForSeconds(2);
        gameOverText.gameObject.SetActive(false);
        EditorApplication.isPlaying = false;
    }
}
