using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScaleTransformNew : MonoBehaviour
{
    // Start is called before the first frame update
    private bool zoomStaus;
    public GameObject player;
    public int shrinkBallNum;
    public int zoomBallNum;
    public GameObject poviot;
    //public Image blackScreenImage;
    public GameObject blackScreenImage;


    private bool fastSlowMode=false;

    void Start()
    {
        zoomStaus = false;
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ScaleChage();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            fastSlowMode = !fastSlowMode;
        }
    }

    void ScaleChage()
    {
        if (fastSlowMode)
        {
            
            StartCoroutine(BlackScreenAndTransform());
        }
        else
        {
            
            PerformScaleChange();
        }
    }

    IEnumerator BlackScreenAndTransform()
    {
      
        blackScreenImage.SetActive(true);

        
        yield return new WaitForSeconds(2f);

        
        blackScreenImage.SetActive(false);

       
        PerformScaleChange();
    }

    void PerformScaleChange()
    {
        if (zoomStaus == false && shrinkBallNum > 0)
        {
            player.transform.localScale *= 0.1f;
            zoomStaus = true;
            poviot.transform.position += new Vector3(0, -1, -1);
            shrinkBallNum--;
            //player.GetComponent<ThirdPersonCharacter>().m_MoveSpeedMultiplier = 3f;
        }
        else if (zoomStaus == true && zoomBallNum > 0)
        {
            player.transform.localScale *= 10f;
            poviot.transform.position += new Vector3(0, 1, 1);
            zoomStaus = false;
            //player.GetComponent<ThirdPersonCharacter>().m_MoveSpeedMultiplier = 1f;
            zoomBallNum--;
        }
    }
}



