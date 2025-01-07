using UnityEngine;
using UnityEngine.AI;

public class FollowPlayerWithNavMesh : MonoBehaviour
{
    public Transform playerCamera;  // Camera principală a jucătorului (sau obiectul ce reprezintă jucătorul)
    public NavMeshAgent agent;     // NavMeshAgent-ul care va urmări jucătorul

    public float followDistance = 2f;  // Distanța la care ghidul va rămâne față de jucător

    void Start()
    {
        if (playerCamera == null)
        {
            Debug.LogError("Player Camera is not assigned!");
            return;
        }

        if (agent == null)
        {
            agent = GetComponent<NavMeshAgent>();
        }
    }

    void Update()
    {
        // Calculăm poziția dorită a ghidului
        Vector3 targetPosition = playerCamera.position + playerCamera.forward * followDistance;

        // Folosim NavMeshAgent pentru a urmări jucătorul
        agent.SetDestination(targetPosition);
    }
}