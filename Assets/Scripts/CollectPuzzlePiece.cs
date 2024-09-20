using UnityEngine;
using Oculus.Interaction;
using System;

public class CollectPuzzlePiece : MonoBehaviour
{
    public GrabInteractor rightControllerGrabInteractor; 

    public static event Action<string> OnBlockCollected;

    private GameObject grabbedObject;

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
          
            if (rightControllerGrabInteractor != null && rightControllerGrabInteractor.HasSelectedInteractable)
            {
                grabbedObject = rightControllerGrabInteractor.SelectedInteractable.transform.gameObject;
                if (grabbedObject.name.StartsWith("PBlock"))
                {
                    string blockName = grabbedObject.name; 
                    Debug.Log("Block Collected: " + blockName);
                    Destroy(grabbedObject); 
                    grabbedObject = null; 

                    // 触发事件，并传递被销毁的Block名称
                    OnBlockCollected?.Invoke(blockName);
                }
            }
        }
    }
}
