using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private GameObject coin;

    [SerializeField] private float timeToSpawn = 1;
    private float currentTime;

    private void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") && currentTime <= 0)
        {
            SpawnCoin();
        }
    }
    private void SpawnCoin()
    {
        Instantiate(coin, transform.position, Quaternion.identity);
        currentTime = timeToSpawn;
    }
}
