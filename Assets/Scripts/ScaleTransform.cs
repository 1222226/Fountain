using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;

public class ScaleTransform : MonoBehaviour
{
    // Start is called before the first frame update
    private bool zoomStaus;
    public bool scaleL = true;
    public GameObject player;
    public int shrinkBallNum;
    public int zoomBallNum;
    public GameObject blackScreenImage;
    public GameObject blackScreenText1;
    public GameObject blackScreenText2;

    public SlowDown slowDownScript;

    public TextMeshProUGUI textZoom;
    public TextMeshProUGUI textShrink;
    public GameObject uiFollowView;
    


    private bool fastSlowMode = false;
    void Start()
    {
        zoomStaus = false;
          textZoom.text=zoomBallNum.ToString();
    textShrink.text=shrinkBallNum.ToString();

}

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            ScaleChage();
        }
        
        /*if (OVRInput.GetDown(OVRInput.Button.Three))
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
        }*/
    }

    void ScaleChage()
    {
        if (slowDownScript.isSlowedDown==true)
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
        blackScreenText1.SetActive(true);
        blackScreenText2.SetActive(false);

       
        yield return new WaitForSeconds(2f);

        
        blackScreenText1.SetActive(false);
        blackScreenText2.SetActive(true);

        if (scaleL) 
        {
            blackScreenText2.GetComponent<TextMeshProUGUI>().text = "You Become Small";
        }
        else 
        {
            blackScreenText2.GetComponent<TextMeshProUGUI>().text = "You Become Normal";
        }

       
        yield return new WaitForSeconds(2f);

        
        blackScreenImage.SetActive(false);
        blackScreenText2.SetActive(false);

        
        PerformScaleChange();
    }

    void PerformScaleChange()
    {
        if (zoomStaus == false && shrinkBallNum > 0)
        {
            player.transform.localScale *= 0.1f;
            zoomStaus = true;
            //poviot.transform.position += new Vector3(0, -1, -1);
            shrinkBallNum--;
            textShrink.text = shrinkBallNum.ToString();
            //player.GetComponent<ThirdPersonCharacter>().m_MoveSpeedMultiplier = 3f;
            uiFollowView.GetComponent<CameraFollow>().distanceFromCamera = uiFollowView.GetComponent<CameraFollow>().distanceFromCamera/10;
            uiFollowView.GetComponent<CameraFollow>().heightOffset = uiFollowView.GetComponent<CameraFollow>().heightOffset /5f;
            scaleL = false;
        }
        else if (zoomStaus == true && zoomBallNum > 0)
        {
            player.transform.localScale *= 10f;
            //poviot.transform.position += new Vector3(0, 1, 1);
            zoomStaus = false;
            //player.GetComponent<ThirdPersonCharacter>().m_MoveSpeedMultiplier = 1f;
           
            zoomBallNum--;
            textZoom.text = zoomBallNum.ToString();
            uiFollowView.GetComponent<CameraFollow>().distanceFromCamera = uiFollowView.GetComponent<CameraFollow>().distanceFromCamera * 10;
            uiFollowView.GetComponent<CameraFollow>().heightOffset = uiFollowView.GetComponent<CameraFollow>().heightOffset *5f;
            scaleL = true;
        }
    }
}
