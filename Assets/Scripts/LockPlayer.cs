using UnityEngine;

public class LockPlayerWhenPanelActive : MonoBehaviour
{
    public GameObject panel; // Ȱ��ȭ�� �г�
    public MonoBehaviour cameraControlScript; // ī�޶� ���� ��ũ��Ʈ (��: MouseLook, CameraController)

    private bool isPanelActive = false;

    void Update()
    {
        // �г� Ȱ��ȭ ���¿� ���� ī�޶� ���� ��ũ��Ʈ Ȱ��ȭ/��Ȱ��ȭ
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
        // ī�޶� ȸ�� ��ũ��Ʈ ��Ȱ��ȭ
        if (cameraControlScript != null)
        {
            cameraControlScript.enabled = false;
        }

        // ���콺 Ŀ�� Ȱ��ȭ
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        isPanelActive = true;
    }

    void UnlockView()
    {
        // ī�޶� ȸ�� ��ũ��Ʈ Ȱ��ȭ
        if (cameraControlScript != null)
        {
            cameraControlScript.enabled = true;
        }

        // ���콺 Ŀ�� ���
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        isPanelActive = false;
    }
}
