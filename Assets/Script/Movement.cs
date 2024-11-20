using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 2.0f;
    [SerializeField]
    private float jumpSpeed = 5.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.linearVelocity = movement * speed;

        // Keep the object upright
        rb.rotation = Quaternion.Euler(0.0f, rb.rotation.eulerAngles.y, 0.0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Chest"))
        {
            Debug.Log("Collided with a cube!");
            transform.position = new Vector3(10.0f, transform.position.y, 10.0f); // Move to a new position
        }
    }
}
