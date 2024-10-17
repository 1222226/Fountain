using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update

    //private GameObject ball;
    public bool ballType; 
  
    void Start()
    {
        //ball = GetComponent<GameObject>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            ScaleTransform scaleTransform = other.gameObject.GetComponent<ScaleTransform>();
            if (ballType == true)
            {
                scaleTransform.shrinkBallNum++;
                scaleTransform.textShrink.text = scaleTransform.shrinkBallNum.ToString();

            }
            else
            {
                scaleTransform.zoomBallNum++;
                scaleTransform.textZoom.text = scaleTransform.zoomBallNum.ToString();
            }
            Destroy(gameObject);
        }
    }
}

