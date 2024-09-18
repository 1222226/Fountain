using UnityEngine;
using Oculus.Interaction;
using System;

public class MakePuzzle2 : MonoBehaviour
{
    public GrabInteractor rightControllerGrabInteractor; // 右手控制器的抓取交互器
    public Collider[] targetColliders; // 用于存储多个目标碰撞器

    private GameObject grabbedObject;

    private void Update()
    {
        // 检查是否抓取了物体
        if (rightControllerGrabInteractor != null && rightControllerGrabInteractor.HasSelectedInteractable)
        {
            grabbedObject = rightControllerGrabInteractor.SelectedInteractable.transform.gameObject;
            string grabbedObjectName = grabbedObject.name;
            grabbedObjectName = grabbedObject.name.Replace("(Clone)", "").Trim(); ;
            // 检查手上抓取的物体是否与任何一个目标碰撞器发生碰撞
            foreach (Collider targetCollider in targetColliders)
            {
                // 检查抓取的物体是否碰撞到某个碰撞器
                if (grabbedObject != null && targetCollider != null && grabbedObject.GetComponent<Collider>().bounds.Intersects(targetCollider.bounds))
                {
                    
                    string colliderObjectName = targetCollider.gameObject.name; // 获取碰撞器挂载物体的名字

                    
                     colliderObjectName = targetCollider.gameObject.name.Replace("(Colider)", "").Trim(); ;

                    Debug.Log("Block Collected: " + grabbedObjectName);
                    Debug.Log("Collider Object Name: " + colliderObjectName);

                    // 检查名字是否相同
                    if (grabbedObjectName == colliderObjectName)
                    {
                        Debug.Log("Names match, performing actions...");

                        // 销毁抓取的物体
                        Destroy(grabbedObject);

                        // 激活碰撞器挂载的物体
                        targetCollider.gameObject.SetActive(true);

                        // 清除引用
                        grabbedObject = null;

                        // 一旦匹配，退出循环
                        break;
                    }
                }
            }
        }
    }
}
