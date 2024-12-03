using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class ForcedReset : MonoBehaviour
{
    private void Update()
    {
        // ResetObject 버튼이 눌렸는지 확인
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            // 현재 씬 다시 로드
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
