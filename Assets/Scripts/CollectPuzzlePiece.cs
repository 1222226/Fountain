using UnityEngine;
using Oculus.Interaction;
using System;

public class CollectPuzzlePiece : MonoBehaviour
{
    public GrabInteractor rightControllerGrabInteractor; // 右手控制器的抓取交互器

    public static event Action<string> OnBlockCollected;

    private GameObject grabbedObject;

    private void Update()
    {
        // 检测 A 键是否按下 (Oculus 的 A 键为 Button.One)
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            // 检查是否抓取了物体
            if (rightControllerGrabInteractor != null && rightControllerGrabInteractor.HasSelectedInteractable)
            {
                grabbedObject = rightControllerGrabInteractor.SelectedInteractable.transform.gameObject;
                if (grabbedObject.name.StartsWith("PBlock"))
                {
                    string blockName = grabbedObject.name; // 获取Block的名称
                    Debug.Log("Block Collected: " + blockName);
                    Destroy(grabbedObject); // 销毁抓取的物体
                    grabbedObject = null; // 清除引用

                    // 触发事件，并传递被销毁的Block名称
                    OnBlockCollected?.Invoke(blockName);
                }
            }
        }
    }
}
