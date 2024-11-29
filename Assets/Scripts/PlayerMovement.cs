using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;
    public LayerMask groundLayer; // ������ �ν��� ���̾� ����
    public float groundCheckDistance = 0.2f; // �� ���� �Ÿ�

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

        // �� ����
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);

        // ���� �Է�
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
