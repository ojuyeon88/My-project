using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Ctrl : MonoBehaviour
{
    Rigidbody rb;

    [Header("Rotate")]
    [Range(1f, 10f)] // 마우스 감도 조정 범위
    public float mouseSpeed = 5f;
    float yRotation;
    float xRotation;
    Camera cam;

    [Header("UI Control")]
    public GameObject panel; // UI 패널 오브젝트
    private bool isPanelActive = false; // 패널 활성화 상태 플래그

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   // 마우스 커서를 화면 안에서 고정
        Cursor.visible = false;                     // 마우스 커서를 보이지 않도록 설정

        rb = GetComponent<Rigidbody>();             // Rigidbody 컴포넌트 가져오기
        rb.freezeRotation = true;                   // Rigidbody의 회전을 고정하여 물리 연산에 영향을 주지 않도록 설정

        cam = Camera.main;                          // 메인 카메라를 할당
    }

    void Update()
    {
        // 패널 활성화 상태 업데이트
        if (panel != null)
        {
            isPanelActive = panel.activeSelf;
        }

        // 패널이 활성화된 상태에서는 Rotate 비활성화
        if (!isPanelActive)
        {
            Rotate(); // 패널이 비활성화된 경우에만 시야 회전
        }

        // ESC 키로 패널 닫기
        if (Input.GetKeyDown(KeyCode.Escape) && isPanelActive)
        {
            ClosePanel();
        }
    }

    void Rotate()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * mouseSpeed;
        float mouseY = Input.GetAxisRaw("Mouse Y") * mouseSpeed;

        yRotation += mouseX;    // 마우스 X축 입력에 따라 수평 회전 값을 조정
        xRotation -= mouseY;    // 마우스 Y축 입력에 따라 수직 회전 값을 조정

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);  // 수직 회전 값을 -90도에서 90도 사이로 제한

        cam.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0); // 카메라의 회전을 조절
        transform.rotation = Quaternion.Euler(0, yRotation, 0);             // 플레이어 캐릭터의 회전을 조절
    }

    public void OpenPanel()
    {
        if (panel != null)
        {
            panel.SetActive(true); // 패널 활성화
            Cursor.lockState = CursorLockMode.None; // 마우스 커서 활성화
            Cursor.visible = true;
        }
    }

    void ClosePanel()
    {
        if (panel != null)
        {
            panel.SetActive(false); // 패널 비활성화
            Cursor.lockState = CursorLockMode.Locked; // 마우스 커서 잠금
            Cursor.visible = false;
        }
    }
}
