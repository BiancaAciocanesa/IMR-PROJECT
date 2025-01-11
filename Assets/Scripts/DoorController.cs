using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public SnakeGameController controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BadKey"))
        {
            Destroy(other.gameObject);
            controller.TryAgain();
        }

        if (other.gameObject.CompareTag("GoodKey"))
        {
            Destroy(other.gameObject);
            controller.YouWon();
        }
    }
}
