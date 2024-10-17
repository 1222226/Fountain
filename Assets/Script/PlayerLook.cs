using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;  // mouse sensitivity
    public Transform playerBody;           
    public Transform cameraTransform;      

    private float xRotation = 0f;

    void Start()
    {
        // hide and lock mouse
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        //get mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);  

        
        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
