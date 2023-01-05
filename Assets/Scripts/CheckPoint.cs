using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    //Khi Player va chạm với CheckPoint(lá cờ)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerRespawn>().ReachedCheckPoint(transform.position.x,transform.position.y);

            //kích hoạt lá cờ
            GetComponent<Animator>().enabled = true;
        }  
    }
}
