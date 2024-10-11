//using Meta.XR.ImmersiveDebugger.UserInterface.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject setScreen;
    public Button setButton;
    public Button oKButton;
    void Start()
    {
        setButton.onClick.AddListener(() => OpenSetting());
        oKButton.onClick.AddListener(() => CloseSetting());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OpenSetting()
    {
        setScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    void CloseSetting()
    {
        setScreen.SetActive(false);
        Time.timeScale = 1f;
    }
}
