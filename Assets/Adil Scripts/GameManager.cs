using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] public Canvas winCanvas; // Reference to the Win Canvas

    private HashSet<string> collectedPapers = new HashSet<string>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CollectPaper(string paperID)
    {
        collectedPapers.Add(paperID);
        Debug.Log($"Collected paper: {paperID}");

        // Check win condition
        if (HasWon())
        {
            ShowWinCanvas();
        }
    }

    public bool IsPaperCollected(string paperID)
    {
        return collectedPapers.Contains(paperID);
    }

    public bool HasWon()
    {
        return collectedPapers.Count >= 2; // Adjust the number of papers required to win
    }

    private void ShowWinCanvas()
    {
        if (winCanvas != null)
        {
            winCanvas.gameObject.SetActive(true); // Enable the win canvas
            Debug.Log("You Win!");
        }
        else
        {
            Debug.LogWarning("Win Canvas is not assigned in the GameManager!");
        }
    }
}
