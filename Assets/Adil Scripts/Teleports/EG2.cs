using UnityEngine;
using UnityEngine.SceneManagement;

public class EG2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("EG2");
        }
    }
}
