using UnityEngine;

public class XRDeviceSimulatorManager : MonoBehaviour
{
    private static XRDeviceSimulatorManager instance;

    private void Awake()
    {
        // Check if another instance of the XR Device Simulator already exists
        if (instance != null && instance != this)
        {
            Destroy(gameObject); // Destroy the new instance
            return;
        }

        // Set this instance as the singleton and prevent destruction on scene load
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
