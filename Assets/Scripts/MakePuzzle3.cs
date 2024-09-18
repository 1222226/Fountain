using UnityEngine;

public class GrabbedObjectTrigger : MonoBehaviour
{

    public GameObject MappingBlock;
    private void OnTriggerEnter(Collider other)
    {
        string thisObjectName = gameObject.name;
        Debug.Log("OringinObjectName: " + thisObjectName);
       thisObjectName = gameObject.name.Replace("Colider", "").Trim();
        string colliderObjectName = other.gameObject.name.Replace("(Clone)", "").Trim(); ;

        Debug.Log("thisObjectName: " + thisObjectName);
        Debug.Log("Collider Object: " + colliderObjectName);

        // 检查名字是否相同
        if (thisObjectName == colliderObjectName)
        {
            Debug.Log("Names match, performing actions...");
            Destroy(other.gameObject); // 销毁抓取的物体
            MappingBlock.SetActive(true); // 激活碰撞器挂载的物体
        }
    }
}
