using UnityEngine;
using UnityEngine.SceneManagement;

public class CH1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("CH1");
        }
    }
}
