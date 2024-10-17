//using Meta.XR.ImmersiveDebugger.UserInterface.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public Button nextLevelButton;

    public Button testNextButton;
    void Start()
    {
        Time.timeScale = 1f;
        startButton.onClick.AddListener(() => StartGame());

        testNextButton.onClick.AddListener(LoadNextLevel);
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
        nextLevelButton.onClick.AddListener(LoadNextLevel);
    }

    void LoadNextLevel()
    {
        // 恢复时间流动
        Time.timeScale = 1f;

        // 获取当前场景的索引
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // 加载下一个场景（索引 + 1）
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
