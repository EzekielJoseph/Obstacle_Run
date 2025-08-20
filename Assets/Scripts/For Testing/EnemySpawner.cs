using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<Transform> SpawnPoints = new();
    public List<GameObject> ObstaclePrefab = new();
    public float spawnInterval = 2f;  
    public float obstacleLifetime = 5f;   

    private void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            SpawnAnEnemy();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnAnEnemy()
    {
        if (ObstaclePrefab.Count == 0 || SpawnPoints.Count == 0) return;

        // pilih random prefab & spawn point
        int randomObstcaleIndex = Random.Range(0, ObstaclePrefab.Count);
        int randomSpawnIndex = Random.Range(0, SpawnPoints.Count);

        GameObject prefab = ObstaclePrefab[randomObstcaleIndex];
        Transform spawn = SpawnPoints[randomSpawnIndex];

        GameObject obstacle = Instantiate(prefab, spawn.position, Quaternion.identity);

        Destroy(obstacle, obstacleLifetime);
    }
}
