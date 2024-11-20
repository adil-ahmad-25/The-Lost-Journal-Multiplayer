using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    public void ReloadCurrentScene()
    {
        // Get the currently active scene
        Scene currentScene = SceneManager.GetActiveScene();
        // Reload the current scene
        SceneManager.LoadScene(currentScene.name);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadCurrentScene();
        }
    }
}
