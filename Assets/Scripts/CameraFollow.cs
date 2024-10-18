using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Make UI follow the camera
    public Transform cameraTransform; 
    public float distanceFromCamera = 1.0f; 
    public float heightOffset = 1.0f; 

    void Update()
    {
        
        Vector3 newPosition = cameraTransform.position + cameraTransform.forward * distanceFromCamera;
        newPosition.y += heightOffset; 

       
        transform.position = newPosition;

        
        transform.rotation = Quaternion.LookRotation(transform.position - cameraTransform.position);
    }
}