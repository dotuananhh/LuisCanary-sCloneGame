using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartUI : MonoBehaviour
{
    public Sprite[] Heartsprite;

    public PlayerHealth player;

    public Image Heart;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (player.ourHealth > 5)
            player.ourHealth = 5;


        if (player.ourHealth < 0)
            player.ourHealth = 0;

        Heart.sprite = Heartsprite[player.ourHealth];
    }
}