using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class SnakeGameController : MonoBehaviour
{
    public GameObject key1, key2, key3, key4, key5;
    public TextMeshProUGUI youWinText, tryAgainText, gameOverText;

    void Start()
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
    }

    public void YouWon()
    {
        youWinText.gameObject.SetActive(true);
        StartCoroutine(DelayYouWonText());
    }

    public void TryAgain()
    {
        tryAgainText.gameObject.SetActive(true);
        StartCoroutine(DelayTryAgainText());
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
