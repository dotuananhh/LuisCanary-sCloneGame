using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
    //Xét sự kiện khi Player va chạm với bẫy
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();

        if (collision.transform.CompareTag("Player"))
        {
            //Trừ 5 máu của Player
            playerHealth.Damage(1);       
        }
    }
}
