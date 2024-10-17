using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearMovement : MonoBehaviour
{
    public float rotationSpeed = 100f;  // ������ת�ٶ�
    public float moveSpeed = 1f;        // ���������ƶ��ٶ�
    public float moveRange = 1.2f;        // ���������ƶ��ķ�Χ

    private float moveDirection = 1f;   // �ƶ�����
    private Vector3 startPosition;      // ���ֵĳ�ʼλ��

    void Start()
    {
        // ��¼���ֵĳ�ʼλ��
        startPosition = transform.position;
    }

    void Update()
    {
        // 1. ������Z����ת
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);

        // 2. ������Z�����������ƶ�
        // ���ڳ�ʼλ�ã���������µ�Z�����ϵ�λ��
        float newZ = startPosition.z + Mathf.Sin(Time.time * moveSpeed) * moveRange;

        // ���³��ֵ�λ��
        transform.position = new Vector3(transform.position.x, transform.position.y, newZ);
    }
}
