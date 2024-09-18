using UnityEngine;
using Oculus.Interaction;
using System;

public class MakePuzzle2 : MonoBehaviour
{
    public GrabInteractor rightControllerGrabInteractor; // ���ֿ�������ץȡ������
    public Collider[] targetColliders; // ���ڴ洢���Ŀ����ײ��

    private GameObject grabbedObject;

    private void Update()
    {
        // ����Ƿ�ץȡ������
        if (rightControllerGrabInteractor != null && rightControllerGrabInteractor.HasSelectedInteractable)
        {
            grabbedObject = rightControllerGrabInteractor.SelectedInteractable.transform.gameObject;
            string grabbedObjectName = grabbedObject.name;
            grabbedObjectName = grabbedObject.name.Replace("(Clone)", "").Trim(); ;
            // �������ץȡ�������Ƿ����κ�һ��Ŀ����ײ��������ײ
            foreach (Collider targetCollider in targetColliders)
            {
                // ���ץȡ�������Ƿ���ײ��ĳ����ײ��
                if (grabbedObject != null && targetCollider != null && grabbedObject.GetComponent<Collider>().bounds.Intersects(targetCollider.bounds))
                {
                    
                    string colliderObjectName = targetCollider.gameObject.name; // ��ȡ��ײ���������������

                    
                     colliderObjectName = targetCollider.gameObject.name.Replace("(Colider)", "").Trim(); ;

                    Debug.Log("Block Collected: " + grabbedObjectName);
                    Debug.Log("Collider Object Name: " + colliderObjectName);

                    // ��������Ƿ���ͬ
                    if (grabbedObjectName == colliderObjectName)
                    {
                        Debug.Log("Names match, performing actions...");

                        // ����ץȡ������
                        Destroy(grabbedObject);

                        // ������ײ�����ص�����
                        targetCollider.gameObject.SetActive(true);

                        // �������
                        grabbedObject = null;

                        // һ��ƥ�䣬�˳�ѭ��
                        break;
                    }
                }
            }
        }
    }
}
