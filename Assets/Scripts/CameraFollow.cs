using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform cameraTransform; 
    public float distanceFromCamera = 2.0f; 
    public float heightOffset = 1.0f; 

    void Update()
    {
        
        Vector3 newPosition = cameraTransform.position + cameraTransform.forward * distanceFromCamera;
        newPosition.y += heightOffset; // 添加可选的高度偏移

       
        transform.position = newPosition;

        
        transform.rotation = Quaternion.LookRotation(transform.position - cameraTransform.position);
    }
}