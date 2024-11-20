using UnityEngine;

public class PaperCollector : MonoBehaviour
{
    [SerializeField] private string paperID; // Unique ID for this paper

    private void Start()
    {
        // Check if this paper has already been collected
        if (GameManager.Instance != null && GameManager.Instance.IsPaperCollected(paperID))
        {
            Destroy(gameObject); // Destroy this paper if it's already collected
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Assume the player has a tag "Player"
        {
            CollectPaper();
        }
    }

    private void CollectPaper()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.CollectPaper(paperID);
        }

        Destroy(gameObject); // Destroy the paper after collection
    }
}
