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
        if (Input.GetKeyDown(KeyCode.P))
        {
            fastSlowMode = !fastSlowMode;
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
            //poviot.transform.position += new Vector3(0, -1, -1);
            shrinkBallNum--;
            textShrink.text = shrinkBallNum.ToString();
            //player.GetComponent<ThirdPersonCharacter>().m_MoveSpeedMultiplier = 3f;
            uiFollowView.GetComponent<CameraFollow>().distanceFromCamera = uiFollowView.GetComponent<CameraFollow>().distanceFromCamera/10;
            uiFollowView.GetComponent<CameraFollow>().heightOffset = uiFollowView.GetComponent<CameraFollow>().heightOffset /2.5f;
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
            uiFollowView.GetComponent<CameraFollow>().heightOffset = uiFollowView.GetComponent<CameraFollow>().heightOffset *2.5f;
        }
    }
}
