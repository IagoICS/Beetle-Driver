using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
   public GameObject coinPrefab;
    public int numberOfCoinsToSpawn = 3;
    public float spawnInterval = 2f;
    public float spawnRadius = 5f;
    public LayerMask coinLayer;
    public float coinHeight = 1.0f;
    public float coinLifetime = 10f; 

    private float timeSinceLastSpawn = 0f;

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            for (int i = 0; i < numberOfCoinsToSpawn; i++)
            {
                Vector3 randomSpawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
                randomSpawnPosition.y = transform.position.y + coinHeight;
                GameObject newCoin = Instantiate(coinPrefab, randomSpawnPosition, Quaternion.identity);
                newCoin.layer = 9;

              
                Destroy(newCoin, coinLifetime);
            }

            timeSinceLastSpawn = 0f;
        }
    }

    public void DestroyCoin(GameObject coin)
    {
        Destroy(coin);
    }
}