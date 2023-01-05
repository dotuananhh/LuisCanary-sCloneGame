using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPointObjectMiniGame : MonoBehaviour
{
    public int pointValue = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<MiniGameManager>().AddPoint(pointValue);
        }
    }
}
