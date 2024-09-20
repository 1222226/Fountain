using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTransform : MonoBehaviour
{
    // Start is called before the first frame update

    public bool scaleL = true;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            if (scaleL)
            {
                player.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                scaleL = false;
            }
            else
            {
                player.transform.localScale = new Vector3(1f, 1f, 1f);
                scaleL = true;
            }
        }
    }
}
