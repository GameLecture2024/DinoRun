using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) // trigger 충돌
    {
        // 선인장이 플레이어와 충동했을 때만 게임을 재시작하세요
        if (collision.CompareTag("Player")) 
        {
            SceneManager.LoadScene(0);
        }       
    }
}
