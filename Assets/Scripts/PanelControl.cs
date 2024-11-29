using UnityEngine;
using UnityEngine.UI;

public class PanelControl : MonoBehaviour
{
    public GameObject panel; // 활성화할 UI 패널
    public GameObject player; // 플레이어 오브젝트
    public MonoBehaviour[] playerControls; // 비활성화할 플레이어 제어 스크립트

    private bool isPanelActive = false;

    void Start()
    {
        panel.SetActive(false); // 패널을 비활성화된 상태로 시작
    }

    void Update()
    {
        // 패널이 활성화된 상태에서 ESC를 누르면 닫기
        if (isPanelActive && Input.GetKeyDown(KeyCode.Escape))
        {
            ClosePanel();
        }
    }

    void OnMouseDown()
    {
        // 패널 활성화
        if (!isPanelActive)
        {
            OpenPanel();
        }
    }

    void OpenPanel()
    {
        panel.SetActive(true); // 패널 활성화
        isPanelActive = true;

        // 플레이어 제어 비활성화
        foreach (var control in playerControls)
        {
            control.enabled = false;
        }

        // 마우스 커서 활성화
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void ClosePanel()
    {
        panel.SetActive(false); // 패널 비활성화
        isPanelActive = false;

        // 플레이어 제어 활성화
        foreach (var control in playerControls)
        {
            control.enabled = true;
        }

        // 마우스 커서 잠금
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
