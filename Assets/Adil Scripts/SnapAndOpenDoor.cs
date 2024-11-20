using UnityEngine;

public class SnapAndOpenDoor : MonoBehaviour
{
    [Header("Target Settings")]
    public Transform givenPosition; // The target position to move the "Cat" object to      

    [Header("Animation Settings")]
    public Animator animator; // Animator component for the door 


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cat"))
        {
            // Move the object to the given position
            other.transform.position = givenPosition.position;
            other.transform.rotation = Quaternion.Euler(0f, 0f, 0f);


            // Check if the object is at the given position
            if (Vector3.Distance(other.transform.position, givenPosition.position) < 5f )
            {
                animator.SetTrigger("OpenDoor");
            }
        }
    }
}
