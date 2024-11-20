using UnityEngine;
using UnityEngine.SceneManagement;

public class CH2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("CH2");
        }
    }
}
