using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;
    public LayerMask groundLayer; // 땅으로 인식할 레이어 설정
    public float groundCheckDistance = 0.2f; // 땅 감지 거리

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // 플레이어가 뒤집히지 않도록 회전 잠금
    }

    void Update()
    {
        // 입력 받기
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // 방향 벡터 계산
        Vector3 moveDirection = transform.right * moveHorizontal + transform.forward * moveVertical;

        // 이동
        rb.velocity = moveDirection * speed + new Vector3(0, rb.velocity.y, 0);

        // 땅 감지
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);

        // 점프 입력
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
