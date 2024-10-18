using UnityEngine;
using Oculus.Interaction;
using System;

public class CollectPuzzlePiece : MonoBehaviour
{
    public GrabInteractor rightControllerGrabInteractor; 

    public static event Action<string> OnBlockCollected;

    private GameObject grabbedObject;
    //collect puzzle piece while grabbing

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

                    
                    OnBlockCollected?.Invoke(blockName);
                }

               
            }
        }
    }
}
