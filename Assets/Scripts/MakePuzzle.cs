using UnityEngine;
using Oculus.Interaction;
using System;

public class MakePuzzle : MonoBehaviour
{
    public GrabInteractor rightControllerGrabInteractor; 

    private GameObject grabbedObject;

    private void Update()
    {
       
        if (rightControllerGrabInteractor != null && rightControllerGrabInteractor.HasSelectedInteractable)
        {
            grabbedObject = rightControllerGrabInteractor.SelectedInteractable.transform.gameObject;
        }

        else
        {
            grabbedObject = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter: " + other.name);
        if (grabbedObject != null&&other.name.EndsWith("Colider"))
        {
            string grabbedObjectName = grabbedObject.name.Replace("(Clone)", "").Trim(); ; 
            string colliderObjectName = other.gameObject.name.Replace("(Colider)", "").Trim(); ;

            Debug.Log("Grabbed Object: " + grabbedObjectName);
            Debug.Log("Collider Object: " + colliderObjectName);

          
            if (grabbedObjectName == colliderObjectName)
            {
                Debug.Log("Names match, performing actions...");

                
                Destroy(grabbedObject);

                
                other.gameObject.GetComponent<MeshRenderer>().enabled=true;
            }
        }
    }
}
