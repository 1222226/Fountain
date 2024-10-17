using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;  // 控制角色的移动速度 // Movement speed
    private Rigidbody rb;
    public Transform cameraTransform;

    void Start()
    {
        // 获取 Rigidbody 组件 // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        // 获取 WASD 输入 // Get WASD input
        Vector3 forward = cameraTransform.forward;  // 摄像机的前方 // Camera's forward direction
        Vector3 right = cameraTransform.right;      // 摄像机的右方 // Camera's right direction

        // 计算移动方向 // Calculate movement direction
        Vector3 movement = (forward * moveZ + right * moveX) * speed * Time.fixedDeltaTime;

        // 移动角色 // Move the character using Rigidbody.MovePosition
        rb.MovePosition(transform.position + movement);
    }
}