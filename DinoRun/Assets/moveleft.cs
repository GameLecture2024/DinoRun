using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveleft : MonoBehaviour
{
    public float speed = 1f; // 방향 * 속도
    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
