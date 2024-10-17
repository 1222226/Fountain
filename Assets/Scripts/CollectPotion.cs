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

                if (grabbedObject.tag==("SPotion"))
                {
                    Player.GetComponent<ScaleTransform>().shrinkBallNum++;
                    Player.GetComponent<ScaleTransform>().textZoom.text = Player.GetComponent<ScaleTransform>().zoomBallNum.ToString();
                    Destroy(grabbedObject);
                    grabbedObject = null;


                }


            }
        }
    }
}
