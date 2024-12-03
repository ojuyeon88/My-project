using System;
using UnityEngine;
using UnityEngine.UI; // UnityEngine.UI를 추가하여 Text 컴포넌트를 사용

namespace UnityStandardAssets.Utility
{
    public class SimpleActivatorMenu : MonoBehaviour
    {
        // UnityEngine.UI.Text를 사용
        public Text camSwitchButton; // GUIText를 Text로 교체
        public GameObject[] objects;

        private int m_CurrentActiveObject;

        private void OnEnable()
        {
            // active object starts from first in array
            m_CurrentActiveObject = 0;
            UpdateButtonText();
        }

        public void NextCamera()
        {
            // 다음 활성화할 오브젝트 계산
            int nextActiveObject = m_CurrentActiveObject + 1 >= objects.Length ? 0 : m_CurrentActiveObject + 1;

            // 모든 오브젝트 순회하며 활성화 상태 변경
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].SetActive(i == nextActiveObject);
            }

            m_CurrentActiveObject = nextActiveObject;
            UpdateButtonText();
        }

        private void UpdateButtonText()
        {
            // 활성화된 오브젝트의 이름을 버튼 텍스트로 표시
            if (camSwitchButton != null)
            {
                camSwitchButton.text = objects[m_CurrentActiveObject].name;
            }
        }
    }
}
