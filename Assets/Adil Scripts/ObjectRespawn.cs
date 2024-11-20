using UnityEngine;

public class ObjectRespawn : MonoBehaviour
{
    private Vector3 originalPosition;
    public Transform potRespawn;
    public GameObject pot;

    void Start()
    {
        // Save the initial position of the object
        originalPosition = potRespawn.transform.position;
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        // Check if the object collides with something
        if (collision.gameObject.CompareTag("Pot")) // Replace "Player" with the tag of the object you're colliding with
        {
            Respawn();
        }
    }

    // Method to reset the object to its original position
    void Respawn()
    {
        pot.transform.position = originalPosition;
    }
}
