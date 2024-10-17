using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearMovement : MonoBehaviour
{
    public float rotationSpeed = 100f;  // 齿轮旋转速度
    public float moveSpeed = 1f;        // 齿轮左右移动速度
    public float moveRange = 1.2f;        // 齿轮左右移动的范围

    private float moveDirection = 1f;   // 移动方向
    private Vector3 startPosition;      // 齿轮的初始位置

    void Start()
    {
        // 记录齿轮的初始位置
        startPosition = transform.position;
    }

    void Update()
    {
        // 1. 齿轮沿Z轴旋转
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);

        // 2. 齿轮在Z方向上左右移动
        // 基于初始位置，计算齿轮新的Z方向上的位移
        float newZ = startPosition.z + Mathf.Sin(Time.time * moveSpeed) * moveRange;

        // 更新齿轮的位置
        transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
    }
}
