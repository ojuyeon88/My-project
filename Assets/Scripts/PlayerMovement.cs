using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // �÷��̾ �������� �ʵ��� ȸ�� ���
    }

    void Update()
    {
        // �Է� �ޱ�
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // ���� ���� ���
        Vector3 moveDirection = transform.right * moveHorizontal + transform.forward * moveVertical;

        // �̵�
        rb.velocity = moveDirection * speed + new Vector3(0, rb.velocity.y, 0);
    }
}
