using UnityEngine;
using UnityEngine.UI;

public class PanelControl : MonoBehaviour
{
    public GameObject panel; // Ȱ��ȭ�� UI �г�
    public GameObject player; // �÷��̾� ������Ʈ
    public MonoBehaviour[] playerControls; // ��Ȱ��ȭ�� �÷��̾� ���� ��ũ��Ʈ

    private bool isPanelActive = false;

    void Start()
    {
        panel.SetActive(false); // �г��� ��Ȱ��ȭ�� ���·� ����
    }

    void Update()
    {
        // �г��� Ȱ��ȭ�� ���¿��� ESC�� ������ �ݱ�
        if (isPanelActive && Input.GetKeyDown(KeyCode.Escape))
        {
            ClosePanel();
        }
    }

    void OnMouseDown()
    {
        // �г� Ȱ��ȭ
        if (!isPanelActive)
        {
            OpenPanel();
        }
    }

    void OpenPanel()
    {
        panel.SetActive(true); // �г� Ȱ��ȭ
        isPanelActive = true;

        // �÷��̾� ���� ��Ȱ��ȭ
        foreach (var control in playerControls)
        {
            control.enabled = false;
        }

        // ���콺 Ŀ�� Ȱ��ȭ
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void ClosePanel()
    {
        panel.SetActive(false); // �г� ��Ȱ��ȭ
        isPanelActive = false;

        // �÷��̾� ���� Ȱ��ȭ
        foreach (var control in playerControls)
        {
            control.enabled = true;
        }

        // ���콺 Ŀ�� ���
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
