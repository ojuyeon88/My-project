using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class ForcedReset : MonoBehaviour
{
    private void Update()
    {
        // ResetObject ��ư�� ���ȴ��� Ȯ��
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            // ���� �� �ٽ� �ε�
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
