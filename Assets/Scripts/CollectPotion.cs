using UnityEngine;
using Oculus.Interaction;
using System;

public class CollectPotion : MonoBehaviour
{
    public GrabInteractor rightControllerGrabInteractor;

    //public static event Action<string> OnBlockCollected;

    private GameObject grabbedObject;
    public GameObject Player;


    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {

            if (rightControllerGrabInteractor != null && rightControllerGrabInteractor.HasSelectedInteractable)
            {
                grabbedObject = rightControllerGrabInteractor.SelectedInteractable.transform.gameObject;
                if (grabbedObject.tag==("ZPotion"))
                {
                   Player.GetComponent<ScaleTransform>().zoomBallNum++;
                    Player.GetComponent<ScaleTransform>().textShrink.text = Player.GetComponent<ScaleTransform>().shrinkBallNum.ToString();
                    Destroy(grabbedObject);
                    grabbedObject = null;

                    
                }

                if (grabbedObject != null && grabbedObject.tag == "SPotion")
                {
                    ScaleTransform scaleTransform = Player.GetComponent<ScaleTransform>();

                    if (scaleTransform != null)
                    {
                        scaleTransform.shrinkBallNum++;

                        if (scaleTransform.textZoom != null)
                        {
                            scaleTransform.textZoom.text = scaleTransform.zoomBallNum.ToString();
                        }
                        else
                        {
                            Debug.LogError("textZoom is not assigned in the ScaleTransform component.");
                        }

                        Destroy(grabbedObject);
                        grabbedObject = null;
                    }
                    else
                    {
                        Debug.LogError("ScaleTransform component is missing from the Player object.");
                    }
                }


            }
        }
    }
}
