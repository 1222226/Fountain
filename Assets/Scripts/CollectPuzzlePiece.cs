using UnityEngine;
using Oculus.Interaction;
using System;

public class CollectPuzzlePiece : MonoBehaviour
{
    public GrabInteractor rightControllerGrabInteractor; // ���ֿ�������ץȡ������

    public static event Action<string> OnBlockCollected;

    private GameObject grabbedObject;

    private void Update()
    {
        // ��� A ���Ƿ��� (Oculus �� A ��Ϊ Button.One)
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            // ����Ƿ�ץȡ������
            if (rightControllerGrabInteractor != null && rightControllerGrabInteractor.HasSelectedInteractable)
            {
                grabbedObject = rightControllerGrabInteractor.SelectedInteractable.transform.gameObject;
                if (grabbedObject.name.StartsWith("PBlock"))
                {
                    string blockName = grabbedObject.name; // ��ȡBlock������
                    Debug.Log("Block Collected: " + blockName);
                    Destroy(grabbedObject); // ����ץȡ������
                    grabbedObject = null; // �������

                    // �����¼��������ݱ����ٵ�Block����
                    OnBlockCollected?.Invoke(blockName);
                }
            }
        }
    }
}
