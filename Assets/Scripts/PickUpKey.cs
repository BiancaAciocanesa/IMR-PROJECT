// using UnityEngine;

// public class PickUpKey : MonoBehaviour
// {
//     public Transform handPosition; 
//     private bool isPickedUp = false;

//     void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("MainCamera")) // Asigură-te că player-ul are tag-ul "Player"
//         {
//             isPickedUp = true;
//             transform.SetParent(other.transform); 
//             transform.position = handPosition.position; 
//             transform.rotation = handPosition.rotation;
//             GetComponent<Collider>().enabled = false;
//         }
//     }
// }
