using UnityEngine;
using UnityEngine.InputSystem;

public class ShrinkPlayer : MonoBehaviour
{
    public float shrinkSpeed = 0.1f; // ��ɫ��С���ٶ�
    public float minScale = 0.1f;    // ��С����ֵ�������ɫ����̫С��

    private Vector3 originalScale;   // �����ɫ��ԭʼ����ֵ

    void Start()
    {
        // ��¼��ɫ�ĳ�ʼ����ֵ
        originalScale = transform.localScale;
    }

    void Update()
    {
        // ������루���簴��ĳ������ʼ��С��
        if (Input.GetKey(KeyCode.S)) // ��סS����С
        {
            Shrink();
        }

        // ��ԭ��С����סR����ԭ��С��
        if (Input.GetKey(KeyCode.R))
        {
            ResetScale();
        }
    }

    void Shrink()
    {
        // ��ȡ��ǰ������ֵ
        Vector3 currentScale = transform.localScale;

        // ����С��ɫ��ֱ���ﵽ��С����ֵ
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
        // ����ɫ������ֵ����Ϊ��ʼֵ
        transform.localScale = originalScale;
    }
}
