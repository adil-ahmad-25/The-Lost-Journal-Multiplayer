using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class BridgeAppear : MonoBehaviour
{
    public Animator bridgeAnimator;

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Pot")
        {
            bridgeAnimator.SetTrigger("BridgeAppear");
        }
    }
}
