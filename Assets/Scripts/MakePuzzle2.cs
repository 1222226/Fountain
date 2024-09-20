using UnityEngine;
using Oculus.Interaction;
using System;

public class MakePuzzle2 : MonoBehaviour
{
    public GrabInteractor rightControllerGrabInteractor; 
    public Collider[] targetColliders; 

    private GameObject grabbedObject;

    private void Update()
    {
     
        if (rightControllerGrabInteractor != null && rightControllerGrabInteractor.HasSelectedInteractable)
        {
            grabbedObject = rightControllerGrabInteractor.SelectedInteractable.transform.gameObject;
            string grabbedObjectName = grabbedObject.name;
            grabbedObjectName = grabbedObject.name.Replace("(Clone)", "").Trim(); ;
            
            foreach (Collider targetCollider in targetColliders)
            {
               
                if (grabbedObject != null && targetCollider != null && grabbedObject.GetComponent<Collider>().bounds.Intersects(targetCollider.bounds))
                {
                    
                    string colliderObjectName = targetCollider.gameObject.name; 

                    
                     colliderObjectName = targetCollider.gameObject.name.Replace("(Colider)", "").Trim(); ;

                    Debug.Log("Block Collected: " + grabbedObjectName);
                    Debug.Log("Collider Object Name: " + colliderObjectName);

                    
                    if (grabbedObjectName == colliderObjectName)
                    {
                        Debug.Log("Names match, performing actions...");

                       
                        Destroy(grabbedObject);

                       
                        targetCollider.gameObject.SetActive(true);

                      
                        grabbedObject = null;

                       
                        break;
                    }
                }
            }
        }
    }
}
