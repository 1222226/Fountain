//using Meta.XR.ImmersiveDebugger.UserInterface.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameFlow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject startUI;
    public GameObject endGame;
    public Button startButton;
    public int puzzleMake = 0;
    public GameObject player;
    public GameObject Setbutton;
    void Start()
    {
        startButton.onClick.AddListener(() => StartGame());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void StartGame()
    {
     startUI.SetActive(false);
        Setbutton.SetActive(true);

    }

    public void EndGame()
    {   player.transform.position = new Vector3(15, 0, 30);
        endGame.SetActive(true);
        Time.timeScale = 0f;
    }
}
