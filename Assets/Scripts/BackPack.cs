using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BackPack : MonoBehaviour
{
    //public OVRInput.Button showUIPanelButton = OVRInput.Button.Two; // B ������UI
    public GameObject uiPanel; 
    public Button block1Button;
    public Button block3Button;
    public Button block4Button;
    public Button block5Button;
    public TextMeshProUGUI block1Text;
    public TextMeshProUGUI block3Text;
    public TextMeshProUGUI block4Text;
    public TextMeshProUGUI block5Text;// ��ʾ��������Text
    public GameObject block1Prefab;
    public GameObject block3Prefab;
    public GameObject block4Prefab;
    public GameObject block5Prefab;// Block��Ԥ�Ƽ�
    public Transform player; 

    public int block1Count = 0;
    public int block3Count = 0;
    public int block4Count = 0;
    public int block5Count = 0; // ��ʼ������Ϊ0

    private void OnEnable()
    {
        
        CollectPuzzlePiece.OnBlockCollected += IncrementBlockCount;
        Debug.Log("BackPack has subscribed to OnBlockCollected");
    }
    private void Start()
    {
        // ����UI
        uiPanel.SetActive(false);

        // ������ť����¼�
        block1Button.onClick.AddListener(() => SpawnBlock("PBlock1"));
        block3Button.onClick.AddListener(() => SpawnBlock("PBlock3"));
        block4Button.onClick.AddListener(() => SpawnBlock("PBlock4"));
        block5Button.onClick.AddListener(() => SpawnBlock("PBlock5"));

        // ��������Block5���¼�
       

        // ���³�ʼ�ļ������ı�
        UpdateCounterText();
    }

    private void Update()
    {
        // ��� B ���Ƿ��£�����UI��ʾ/����
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            ToggleUIPanel();
        }
    }

    private void OnDestroy()
    {
        // �ڽű�����ʱȡ�������¼��������ڴ�й©
        CollectPuzzlePiece.OnBlockCollected -= IncrementBlockCount;
    }

    // �л�UI������ʾ������
    private void ToggleUIPanel()
    {
        uiPanel.SetActive(!uiPanel.activeSelf);
    }

    // ���¼������ı���ʾ
    private void UpdateCounterText()
    {
        block1Text.text = block1Count.ToString();
        block3Text.text = block3Count.ToString();
        block4Text.text = block4Count.ToString();
        block5Text.text = block5Count.ToString();// ��ʾ��ǰ��block����
    }

    // �����µ�Block5
    private void SpawnBlock(string blockname)
    {   Debug.Log("SpawnBlock called for: " + blockname);
        switch
            (blockname)
        {
            case "PBlock1":
                if (block1Count > 0)
                {
                    // �����ǰ������Block1
                    Vector3 spawnPosition = player.position + player.forward * 1f+player.up * 1f; // 
                    Instantiate(block1Prefab, spawnPosition, Quaternion.identity);

                    block1Count--; // ���ɺ���ټ�����
                }

                break;

            case "PBlock3":
                if (block3Count > 0)
                {
                    // �����ǰ������Block3
                    Vector3 spawnPosition = player.position + player.forward * 1f + player.up * 1f; // 
                    Instantiate(block3Prefab, spawnPosition, Quaternion.identity);

                    block3Count--; 
                }
                break;

            case "PBlock4":
                if (block4Count > 0)
                {
                    // �����ǰ������Block4
                    Vector3 spawnPosition = player.position + player.forward * 1f+player.up*1f; // 
                    Instantiate(block4Prefab, spawnPosition, Quaternion.identity);

                    block4Count--; // ���ɺ���ټ�����
                }
                break;

            case "PBlock5":
                if (block5Count > 0)
                {
                    // �����ǰ������Block5
                    Vector3 spawnPosition = player.position + player.forward * 1f+player.up * 1f; // 
                    Instantiate(block5Prefab, spawnPosition, Quaternion.identity);

                    block5Count--; // ���ɺ���ټ�����
                }
                break;
        }
            UpdateCounterText(); // ���¼������ı�

            uiPanel.SetActive(false); // ����UI
    }



    /*public void SpawnBlock5()
    {
        if (block5Count > 0)
                {
                    // �����ǰ������Block5
                    Vector3 spawnPosition = player.position + player.forward * 1f; // 
                    Instantiate(blockPrefab, spawnPosition, Quaternion.identity);

                    block5Count--; // ���ɺ���ټ�����
                }
               
        
        UpdateCounterText(); // ���¼������ı�

        uiPanel.SetActive(false); // ����UI
    }*/


    // ����Block5ʱ����������
    private void IncrementBlockCount(string blockname)
    {
        Debug.Log("IncrementBlockCount called for: " + blockname);
        switch (blockname)
        {
            case "PBlock1":
                block1Count++;
                break;
            case "PBlock3":
                block3Count++;
                break;
            case "PBlock4":
                block4Count++;
                break;
            case "PBlock5":
                Debug.Log("Block5 Count is now: " + block5Count);
                block5Count++;
                break;
        }
         // ����������
        UpdateCounterText(); // ������ʾ���ı�
    }
}
