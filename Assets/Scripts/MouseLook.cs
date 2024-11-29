using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;

    private float xRotation = 0f;

    void Start()
    {
        // ���콺 Ŀ�� ���
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // ���콺 �Է� �ޱ�
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // ���� ȸ�� ����
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // ī�޶� ȸ��
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        // �÷��̾� ��ü ȸ��
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
