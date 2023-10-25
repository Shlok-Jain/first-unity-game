using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollect : MonoBehaviour
{
    // public int coinValue = 1;
    // public GameObject coinEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // ScoreManager.instance.ChangeScore(coinValue);
            // Instantiate(coinEffect, transform.position, Quaternion.identity);
            CoinCounter.Count++;
            Destroy(gameObject);
        }
    }
}
