using UnityEngine;

public class CloseParentPanel : MonoBehaviour
{
    public void ClosePanel()
    {
        // 부모 오브젝트를 비활성화
        if (transform.parent != null)
        {
            transform.parent.gameObject.SetActive(false);
        }
    }
}
