using System;
using UnityEngine;
using UnityEngine.UI; // UnityEngine.UI�� �߰��Ͽ� Text ������Ʈ�� ���

namespace UnityStandardAssets.Utility
{
    public class SimpleActivatorMenu : MonoBehaviour
    {
        // UnityEngine.UI.Text�� ���
        public Text camSwitchButton; // GUIText�� Text�� ��ü
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
            // ���� Ȱ��ȭ�� ������Ʈ ���
            int nextActiveObject = m_CurrentActiveObject + 1 >= objects.Length ? 0 : m_CurrentActiveObject + 1;

            // ��� ������Ʈ ��ȸ�ϸ� Ȱ��ȭ ���� ����
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].SetActive(i == nextActiveObject);
            }

            m_CurrentActiveObject = nextActiveObject;
            UpdateButtonText();
        }

        private void UpdateButtonText()
        {
            // Ȱ��ȭ�� ������Ʈ�� �̸��� ��ư �ؽ�Ʈ�� ǥ��
            if (camSwitchButton != null)
            {
                camSwitchButton.text = objects[m_CurrentActiveObject].name;
            }
        }
    }
}
