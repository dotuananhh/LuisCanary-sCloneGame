using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObjectMiniGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            print("a");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
            Destroy(this.gameObject);
        }
    }
    
}
