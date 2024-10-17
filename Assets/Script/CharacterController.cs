using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;  // ���ƽ�ɫ���ƶ��ٶ� // Movement speed
    private Rigidbody rb;
    public Transform cameraTransform;

    void Start()
    {
        // ��ȡ Rigidbody ��� // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        // ��ȡ WASD ���� // Get WASD input
        Vector3 forward = cameraTransform.forward;  // �������ǰ�� // Camera's forward direction
        Vector3 right = cameraTransform.right;      // ��������ҷ� // Camera's right direction

        // �����ƶ����� // Calculate movement direction
        Vector3 movement = (forward * moveZ + right * moveX) * speed * Time.fixedDeltaTime;

        // �ƶ���ɫ // Move the character using Rigidbody.MovePosition
        rb.MovePosition(transform.position + movement);
    }
}