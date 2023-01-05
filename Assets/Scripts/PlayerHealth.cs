using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int ourHealth;
    public int maxhealth = 5;

    public Rigidbody2D r2;

    // Start is called before the first frame update
    void Start()
    {
        r2 = gameObject.GetComponent<Rigidbody2D>();
        ourHealth = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (ourHealth <= 0)
        {
            //Player chết và hồi sinh tại vị trí bắt đầu
            gameObject.GetComponent<PlayerRespawn>().PlayerDeath();
        }
    }

    public void Damage(int damage)
    {
        ourHealth -= damage;
    }
}
