using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public List<Transform> SpawnPoints = new();
    public List<Transform> Items = new();

    private void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            SpawnAnObject();
            yield return new WaitForSeconds(2f); // jeda 2 detik
        }
    }

    void SpawnAnObject()
    {
        if (Items.Count == 0 || SpawnPoints.Count == 0) return;

        int randomItemIndex = Random.Range(0, Items.Count);
        int randomSpawnIndex = Random.Range(0, SpawnPoints.Count);

        Transform item = Items[randomItemIndex];
        item.position = SpawnPoints[randomSpawnIndex].position;
        item.gameObject.SetActive(true);
    }
}
