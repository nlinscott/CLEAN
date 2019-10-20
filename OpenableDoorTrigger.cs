using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenableDoorTrigger : MonoBehaviour
{
    public OpenableOuterDoor OuterDoor;

    // Activate the Main function when Player enter the trigger area
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entered");
            OuterDoor.CanEnter = true;
        }
    }

    // Deactivate the Main function when Player exit the trigger area
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("exit");

            OuterDoor.CanEnter = false;
        }
    }
}