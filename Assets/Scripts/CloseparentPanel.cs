using UnityEngine;

public class CloseParentPanel : MonoBehaviour
{
    public void ClosePanel()
    {
        // �θ� ������Ʈ�� ��Ȱ��ȭ
        if (transform.parent != null)
        {
            transform.parent.gameObject.SetActive(false);
        }
    }
}
