using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnSceneLoad : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        // Play the audio when the scene loads
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogError("No AudioSource assigned to PlayAudioOnSceneLoad script.");
        }
    }
}
