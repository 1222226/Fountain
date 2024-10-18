using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetScene : MonoBehaviour
{
    // ������� Inspector �н���ť��������
    public Button resetButton;
    public Button resetButton2;
    public Button resetButton3;

    void Start()
    {
        // ȷ����ť�Ѿ������������
        resetButton.onClick.AddListener(ResetCurrentScene);
        resetButton2.onClick.AddListener(ResetCurrentScene);
        resetButton3.onClick.AddListener(ResetCurrentScene);
    }

    void ResetCurrentScene()
    {
        // ��ȡ��ǰ����������
        Time.timeScale = 1f;
        string currentSceneName = SceneManager.GetActiveScene().name;

        // ���¼��ص�ǰ����
        SceneManager.LoadScene(currentSceneName);
    }
}
