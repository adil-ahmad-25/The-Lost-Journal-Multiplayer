using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class MouseCamLook : NetworkBehaviour
{
    public float mouseSensitivity = 150f;
    public Transform playerBody;
    private bool isCursorLocked = true;
    float xRotation = 0f;

    void Start()
    {
        // Start with the cursor locked
        ToggleCursorLock(true);
    }

    void Update()
    {
        if (!IsOwner) return;
        
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);

        // Toggle cursor lock state when Escape is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isCursorLocked = !isCursorLocked;
            ToggleCursorLock(isCursorLocked);
        }
    }


    private void ToggleCursorLock(bool lockCursor)
    {
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}

