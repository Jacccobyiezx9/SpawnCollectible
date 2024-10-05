using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject collectiblePrefab;
    public float spawnRate = 2f;
    public float moveSpeed = 2f;
    public float spawnRangeY = 3f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnCollectible), 0f, spawnRate);
    }

    void SpawnCollectible()
    {
        float randomY = Random.Range(-spawnRangeY, spawnRangeY);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, 0f);
        GameObject collectible = Instantiate(collectiblePrefab, spawnPosition, Quaternion.identity);

        CollectibleMovement movement = collectible.AddComponent<CollectibleMovement>();
        movement.moveSpeed = moveSpeed;
    }
}