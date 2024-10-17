//using Meta.XR.ImmersiveDebugger.UserInterface.Generic;
using OVR.OpenVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;

public class SlowDown : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public bool isSlowedDown = false;
    public Button slowDownButton;
    void Start()
    {
        slowDownButton.onClick.AddListener(() => HandelSlowDown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HandelSlowDown()
    {
        if (!isSlowedDown)
        {
            slowDownButton.GetComponent<Image>().color = Color.red;
            player.GetComponent<OVRPlayerControllerCustomize>().MoveScaleMultiplier = player.GetComponent<OVRPlayerControllerCustomize>().MoveScaleMultiplier *0.5f;
            isSlowedDown = true;
        }
        else
        {
            slowDownButton.GetComponent<Image>().color = Color.white;
            player.GetComponent<OVRPlayerControllerCustomize>().MoveScaleMultiplier = player.GetComponent<OVRPlayerControllerCustomize>().MoveScaleMultiplier * 2f;
            isSlowedDown = false;
        }
    }
}
