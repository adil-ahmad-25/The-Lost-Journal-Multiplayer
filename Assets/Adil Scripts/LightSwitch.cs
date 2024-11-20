using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    private bool playerInZone = false; // Check if the player is in the trigger zone
    public Light lightorobj;          // Reference to the Light object
    public float lightIntensity; // Maximum light intensity

    private void Start()
    {
        // Initialize values
        playerInZone = false;
        lightorobj.intensity = 0; // Light starts off
    }

    private void Update()
    {
        if (playerInZone && Input.GetKeyDown(KeyCode.F)) // If in zone and "F" is pressed
        {
            // Toggle the light intensity
            if (lightorobj.intensity > 0)
            {
                lightorobj.intensity = 0; // Turn off the light
            }
            else
            {
                lightorobj.intensity = lightIntensity; // Turn on the light
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // If the player enters the trigger zone
        if (other.gameObject.CompareTag("Player"))
        {
            playerInZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // If the player exits the trigger zone
        if (other.gameObject.CompareTag("Player"))
        {
            playerInZone = false;
        }
    }
}
