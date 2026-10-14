
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject fruitPrefab;
    public GameObject bombPrefab;

    public float spawnInterval = 2f;
    public float spawnRange = 7f;
    public float spawnHeight = 5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnItem), 1f, spawnInterval);
    }

    void SpawnItem()
    {
        GameObject prefabToSpawn =
            Random.value < 0.7f ? fruitPrefab : bombPrefab;

        if (prefabToSpawn == null)
        {
            Debug.LogError("Assign fruitPrefab and bombPrefab!");
            return;
        }

        float x = Random.Range(-spawnRange, spawnRange);

        Instantiate(
            prefabToSpawn,
            new Vector3(x, spawnHeight, 0f),
            Quaternion.identity
        );
    }
}

