using UnityEngine;

public class DisableOnKeyPress : MonoBehaviour
{
    void Update()
    {
        // A 버튼 입력 감지
        if (Input.GetKeyDown(KeyCode.A))
        {
            // 해당 오브젝트를 비활성화
            gameObject.SetActive(false);
        }
    }
}