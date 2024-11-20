using UnityEngine;

public class ChestAnimation : MonoBehaviour
{
    public Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider enter)
    {
        if (enter.CompareTag("Player"))
        {
            ani.SetTrigger("ChestOpen");
        }
    }

    private void OnTriggerExit(Collider exit)
    {
        if (exit.CompareTag("Player"))
        {
            ani.SetTrigger("ChestClose");
        }
    }
}
