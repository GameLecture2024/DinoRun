using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  플레이어가 점프를 한다. -> 공룡
 *  Rigidbody참조
 *  Addforce(위로 점프 파워만큼 올라가라)
 */

/*
 *   점프를 계속 한다.
 */

public class Jump : MonoBehaviour
{
    [Header("참조")]
    public Rigidbody2D rigid;
    [Header("설정")]
    public float jumpPower = 1f;
    public float groundCheckDistance = 1f;
    public LayerMask groundLayer;
    private bool isGrounded;
    
    // Update is called once per frame
    void Update()
    {
        // 유니티 키보드 스페이스바를 입력받았을 때 - 조건
        // rigid에 있는 AddForce Vector.up 실행한다.

        isGrounded = Physics2D.Raycast(transform.position,
            Vector2.down, groundCheckDistance, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigid.AddForce(jumpPower * Vector2.up, ForceMode2D.Impulse);
        }
    }
}
