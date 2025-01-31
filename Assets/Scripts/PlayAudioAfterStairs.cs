using UnityEngine;

public class SoundOnEnterArea : MonoBehaviour
{
    public AudioClip soundClip;
    private AudioSource audioSource;
    public Vector3 zoneCenter;     // centrul zonei in care se va da play la audio
    public float zoneRadius = 5f;  // raza zonei
    public bool played = false;

    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {

        float distance = Vector3.Distance(transform.position, zoneCenter);
        if (distance < zoneRadius && !audioSource.isPlaying && !played)
        {
            played = true;
            audioSource.PlayOneShot(soundClip);
        }
    }
}
