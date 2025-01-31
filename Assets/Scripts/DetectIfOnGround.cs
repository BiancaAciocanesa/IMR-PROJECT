using UnityEngine;
using TMPro;  // Necesită TextMeshPro namespace

public class DetectIfOnGround : MonoBehaviour
{
    public string BoxTag;
    public TextMeshPro successText; // Asignează în Inspector
    public AudioSource successAudio; // Asignează AudioSource în Inspector
    private bool isOnGround = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(BoxTag))
        {
            isOnGround = true;
            Debug.Log(gameObject.name + " este pe " + collision.gameObject.name);

            // Schimbă textul când cubul e pe bază
            if (successText != null)
            {
                successText.text = "Good job! You placed the cube!";
            }

            // Redă sunetul de succes
            if (successAudio != null)
            {
                successAudio.Play(); // Redă audio
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("box"))
        {
            isOnGround = false;
            Debug.Log(gameObject.name + " a părăsit " + collision.gameObject.name);

            // Șterge textul când cubul nu mai este pe bază
            if (successText != null)
            {
                successText.text = "";
            }
        }
    }
}
