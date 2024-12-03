using UnityEngine;
using UnityEngine.UI;

public class noBtn : MonoBehaviour
{
    // ExitPanel을 참조하기 위한 변수
    public GameObject exitPanel;

    // 애니메이션 효과를 위한 Animator
    public Animator exitPanelAnimator;

    // 버튼 클릭 시 사운드 효과 재생을 위한 AudioSource
    public AudioSource clickSound;

    void Start()
    {
        // 버튼의 onClick 이벤트에 함수 등록
        Button btn = GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(OnNoButtonClick);
        }
        else
        {
            Debug.LogError("Button 컴포넌트가 존재하지 않습니다.");
        }
    }

    // 아니오 버튼 클릭 시 호출되는 함수
    void OnNoButtonClick()
    {
        // 클릭 사운드 재생
        if (clickSound != null)
        {
            clickSound.Play();
        }

        // ExitPanel의 페이드 아웃 애니메이션 재생
        if (exitPanelAnimator != null)
        {
            exitPanelAnimator.SetTrigger("FadeOut");
        }
        else
        {
            // Animator가 없으면 즉시 ExitPanel 비활성화
            if (exitPanel != null)
            {
                exitPanel.SetActive(false);
            }
        }
    }

    // 애니메이션 이벤트에서 호출될 함수
    public void DeactivateExitPanel()
    {
        if (exitPanel != null)
        {
            exitPanel.SetActive(false);
        }
    }
}
