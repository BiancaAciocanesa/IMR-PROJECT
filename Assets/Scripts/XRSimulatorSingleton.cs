using UnityEngine;

public class XRSimulatorSingleton : MonoBehaviour
{
    private static XRSimulatorSingleton instance;
    public GameObject gameObject;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject); 
        }
        else
        {
            instance = this; 
            DontDestroyOnLoad(gameObject);
        }
    }
}
