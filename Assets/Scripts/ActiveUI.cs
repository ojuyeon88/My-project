using UnityEngine;

public class DisableOnKeyPress : MonoBehaviour
{
    void Update()
    {
        // A ��ư �Է� ����
        if (Input.GetKeyDown(KeyCode.A))
        {
            // �ش� ������Ʈ�� ��Ȱ��ȭ
            gameObject.SetActive(false);
        }
    }
}