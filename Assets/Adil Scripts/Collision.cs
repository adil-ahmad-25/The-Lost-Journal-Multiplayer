using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    public Canvas gameOverScreen;
    public Transform playerCamera;
    public MouseCamLook mouseCam;

    private void Start()
    {
        gameOverScreen.enabled = false;
        mouseCam.enabled = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerCamera.SetParent(null);
            mouseCam.enabled = false;
            Destroy(other.gameObject);
            gameOverScreen.enabled = true;
        }
    }
}
