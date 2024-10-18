using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetScene : MonoBehaviour
{
   
    public Button resetButton;
    public Button resetButton2;
    public Button resetButton3;

    void Start()
    {
        
        resetButton.onClick.AddListener(ResetCurrentScene);
        resetButton2.onClick.AddListener(ResetCurrentScene);
        resetButton3.onClick.AddListener(ResetCurrentScene);
    }

    void ResetCurrentScene()
    {
        
        Time.timeScale = 1f;
        string currentSceneName = SceneManager.GetActiveScene().name;

        
        SceneManager.LoadScene(currentSceneName);
    }
}
