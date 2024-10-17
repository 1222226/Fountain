using UnityEngine;
using UnityEngine.InputSystem;

public class ShrinkPlayer : MonoBehaviour
{
    public float shrinkSpeed = 0.1f; // 角色变小的速度
    public float minScale = 0.1f;    // 最小缩放值（避免角色缩得太小）

    private Vector3 originalScale;   // 保存角色的原始缩放值

    void Start()
    {
        // 记录角色的初始缩放值
        originalScale = transform.localScale;
    }

    void Update()
    {
        // 检查输入（例如按下某个键开始变小）
        if (Input.GetKey(KeyCode.S)) // 按住S键变小
        {
            Shrink();
        }

        // 还原大小（按住R键还原大小）
        if (Input.GetKey(KeyCode.R))
        {
            ResetScale();
        }
    }

    void Shrink()
    {
        // 获取当前的缩放值
        Vector3 currentScale = transform.localScale;

        // 逐渐缩小角色，直到达到最小缩放值
        if (currentScale.x > minScale && currentScale.y > minScale && currentScale.z > minScale)
        {
            transform.localScale = new Vector3(
                currentScale.x - shrinkSpeed * Time.deltaTime,
                currentScale.y - shrinkSpeed * Time.deltaTime,
                currentScale.z - shrinkSpeed * Time.deltaTime
            );
        }
    }

    void ResetScale()
    {
        // 将角色的缩放值重置为初始值
        transform.localScale = originalScale;
    }
}
