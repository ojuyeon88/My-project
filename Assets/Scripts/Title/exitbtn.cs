using UnityEngine;

public class ExitPanel : MonoBehaviour
{
    // ExitPanel과 ExitBtn을 연결할 public 변수 선언
    public GameObject exitPanel; // ExitPanel 객체 참조
    public GameObject exitBtn;   // ExitBtn 객체 참조

    void Start()
    {
        // ExitBtn의 클릭 이벤트에 함수 연결
        if (exitBtn != null)
        {
            exitBtn.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(DeactivateExitPanel);
        }
    }

    // ExitPanel을 비활성화하는 함수
    void DeactivateExitPanel()
    {
        if (exitPanel != null)
        {
            exitPanel.SetActive(false);
        }
    }
}
