using UnityEngine;

public class LanternPuzzle : MonoBehaviour
{
    public Light lightOne;  // Reference to the first Light
    public Light lightTwo;  // Reference to the second Light
    public Animator doorAni; // Reference to the DoorOpen script

    void Update()
    {
        // Check if both lights have intensity greater than 0
        if (lightOne.intensity > 0 && lightTwo.intensity > 0)
        {
            doorAni.SetTrigger("OpenDoor");
        }
    }
}
