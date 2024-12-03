using UnityEngine;

public class ExitPanelController : MonoBehaviour
{
    // ExitPanel과 ExitBtn을 연결할 수 있도록 public 변수 선언
    public GameObject exitPanel; // ExitPanel 객체를 참조
    public GameObject exitBtn;   // ExitBtn 객체를 참조

    void Start()
    {
        // ExitPanel을 비활성화 상태로 시작
        if (exitPanel != null)
        {
            exitPanel.SetActive(false);
        }

        // ExitBtn에 클릭 이벤트 추가
        if (exitBtn != null)
        {
            exitBtn.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(ActivateExitPanel);
        }
    }

    // ExitPanel을 활성화하는 함수
    void ActivateExitPanel()
    {
        if (exitPanel != null)
        {
            exitPanel.SetActive(true);
        }
    }
}
