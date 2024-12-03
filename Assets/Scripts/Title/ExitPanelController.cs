using UnityEngine;

public class ExitPanelController : MonoBehaviour
{
    // ExitPanel�� ExitBtn�� ������ �� �ֵ��� public ���� ����
    public GameObject exitPanel; // ExitPanel ��ü�� ����
    public GameObject exitBtn;   // ExitBtn ��ü�� ����

    void Start()
    {
        // ExitPanel�� ��Ȱ��ȭ ���·� ����
        if (exitPanel != null)
        {
            exitPanel.SetActive(false);
        }

        // ExitBtn�� Ŭ�� �̺�Ʈ �߰�
        if (exitBtn != null)
        {
            exitBtn.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(ActivateExitPanel);
        }
    }

    // ExitPanel�� Ȱ��ȭ�ϴ� �Լ�
    void ActivateExitPanel()
    {
        if (exitPanel != null)
        {
            exitPanel.SetActive(true);
        }
    }
}
