using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;


public class TeleportToScene : MonoBehaviour
{
    public GameObject player;
    public Vector3 targetPosition;
    public float teleportThreshold = 4.0f;
    public string sceneName; 

    private Transform playerTransform;

    void Start()
    {
        playerTransform = player.transform;
    }

    void Update()
    {
        Debug.Log(Vector3.Distance(playerTransform.position, targetPosition));
        if (Vector3.Distance(playerTransform.position, targetPosition) < teleportThreshold)
        {
            Debug.Log("here");
            
            EditorApplication.isPlaying = false;

            //SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }
}
