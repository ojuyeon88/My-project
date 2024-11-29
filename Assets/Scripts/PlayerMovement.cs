using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

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
    }
}
