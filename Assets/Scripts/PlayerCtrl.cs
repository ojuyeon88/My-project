using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Ctrl : MonoBehaviour
{
    Rigidbody rb;

    [Header("Rotate")]
    [Range(1f, 10f)] // ���콺 ���� ���� ����
    public float mouseSpeed = 5f;
    float yRotation;
    float xRotation;
    Camera cam;

    [Header("UI Control")]
    public GameObject panel; // UI �г� ������Ʈ
    private bool isPanelActive = false; // �г� Ȱ��ȭ ���� �÷���

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   // ���콺 Ŀ���� ȭ�� �ȿ��� ����
        Cursor.visible = false;                     // ���콺 Ŀ���� ������ �ʵ��� ����

        rb = GetComponent<Rigidbody>();             // Rigidbody ������Ʈ ��������
        rb.freezeRotation = true;                   // Rigidbody�� ȸ���� �����Ͽ� ���� ���꿡 ������ ���� �ʵ��� ����

        cam = Camera.main;                          // ���� ī�޶� �Ҵ�
    }

    void Update()
    {
        // �г� Ȱ��ȭ ���� ������Ʈ
        if (panel != null)
        {
            isPanelActive = panel.activeSelf;
        }

        // �г��� Ȱ��ȭ�� ���¿����� Rotate ��Ȱ��ȭ
        if (!isPanelActive)
        {
            Rotate(); // �г��� ��Ȱ��ȭ�� ��쿡�� �þ� ȸ��
        }

        // ESC Ű�� �г� �ݱ�
        if (Input.GetKeyDown(KeyCode.Escape) && isPanelActive)
        {
            ClosePanel();
        }
    }

    void Rotate()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * mouseSpeed;
        float mouseY = Input.GetAxisRaw("Mouse Y") * mouseSpeed;

        yRotation += mouseX;    // ���콺 X�� �Է¿� ���� ���� ȸ�� ���� ����
        xRotation -= mouseY;    // ���콺 Y�� �Է¿� ���� ���� ȸ�� ���� ����

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);  // ���� ȸ�� ���� -90������ 90�� ���̷� ����

        cam.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0); // ī�޶��� ȸ���� ����
        transform.rotation = Quaternion.Euler(0, yRotation, 0);             // �÷��̾� ĳ������ ȸ���� ����
    }

    public void OpenPanel()
    {
        if (panel != null)
        {
            panel.SetActive(true); // �г� Ȱ��ȭ
            Cursor.lockState = CursorLockMode.None; // ���콺 Ŀ�� Ȱ��ȭ
            Cursor.visible = true;
        }
    }

    void ClosePanel()
    {
        if (panel != null)
        {
            panel.SetActive(false); // �г� ��Ȱ��ȭ
            Cursor.lockState = CursorLockMode.Locked; // ���콺 Ŀ�� ���
            Cursor.visible = false;
        }
    }
}
