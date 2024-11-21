using UnityEngine;

public class Collect : MonoBehaviour
{
    private bool playerInZone = false; 
    public GameObject page;          
    //private bool isCollected = false; 

    private void Start()
    {
        playerInZone = false;
    }

    private void Update()
    {
        if (playerInZone && Input.GetKeyDown(KeyCode.F)) 
        {
            Destroy(page.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            playerInZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            playerInZone = false;
        }
    }
}
