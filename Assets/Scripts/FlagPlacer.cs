using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagPlacer : MonoBehaviour
{
    public GameObject flagPrefab; // Prefab-ul steagului
    public KeyCode placeFlagKey = KeyCode.F; // Tasta pentru plasare

    void Update()
    {
        if (Input.GetKeyDown(placeFlagKey))
        {
            PlaceFlag();
        }
    }

    void PlaceFlag()
    {
        // Obține poziția unde să fie plasat steagul
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Instantiate(flagPrefab, hit.point, Quaternion.Euler(0, Random.Range(0, 360), 0));
        }
    }
}