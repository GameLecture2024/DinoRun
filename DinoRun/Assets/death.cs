using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) // trigger �浹
    {
        // �������� �÷��̾�� �浿���� ���� ������ ������ϼ���
        if (collision.CompareTag("Player")) 
        {
            SceneManager.LoadScene(0);
        }       
    }
}
