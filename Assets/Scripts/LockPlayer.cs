using UnityEngine;

public class LockPlayerWhenPanelActive : MonoBehaviour
{
    public GameObject panel; // 활성화할 패널
    public MonoBehaviour cameraControlScript; // 카메라 제어 스크립트 (예: MouseLook, CameraController)

    private bool isPanelActive = false;

    void Update()
    {
        // 패널 활성화 상태에 따라 카메라 제어 스크립트 활성화/비활성화
        if (panel.activeSelf && !isPanelActive)
        {
            LockView();
        }
        else if (!panel.activeSelf && isPanelActive)
        {
            UnlockView();
        }
    }

    void LockView()
    {
        // 카메라 회전 스크립트 비활성화
        if (cameraControlScript != null)
        {
            cameraControlScript.enabled = false;
        }

        // 마우스 커서 활성화
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        isPanelActive = true;
    }

    void UnlockView()
    {
        // 카메라 회전 스크립트 활성화
        if (cameraControlScript != null)
        {
            cameraControlScript.enabled = true;
        }

        // 마우스 커서 잠금
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        isPanelActive = false;
    }
}
