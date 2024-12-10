using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golfBallCollision : MonoBehaviour
{
    private Rigidbody rb;

    public GameController gameController;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Club"))
        {
            Vector3 forceDirection = collision.contacts[0].point - transform.position;
            forceDirection = -forceDirection.normalized;
            rb.AddForce(forceDirection * 100f);
            gameController.IncrementCurrentScore();
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            if (rb.velocity.magnitude < 0.5f)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
        else if (collision.gameObject.CompareTag("Hole"))
        {
            gameController.ScoreByPlayer();
        }
    }
}
