using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, Random.Range(4,7));
    }

    private void GetCoin()
    {
        Score score = FindObjectOfType<Score>();
        score.AddScore();
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            GetCoin();
        }
    }

}
