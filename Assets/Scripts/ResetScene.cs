using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetScene : MonoBehaviour
{
    // 你可以在 Inspector 中将按钮对象拖入
    public Button resetButton;
    public Button resetButton2;
    public Button resetButton3;

    void Start()
    {
        // 确保按钮已经绑定了这个方法
        resetButton.onClick.AddListener(ResetCurrentScene);
        resetButton2.onClick.AddListener(ResetCurrentScene);
        resetButton3.onClick.AddListener(ResetCurrentScene);
    }

    void ResetCurrentScene()
    {
        // 获取当前场景的名称
        Time.timeScale = 1f;
        string currentSceneName = SceneManager.GetActiveScene().name;

        // 重新加载当前场景
        SceneManager.LoadScene(currentSceneName);
    }
}
