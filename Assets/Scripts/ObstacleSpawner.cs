using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject standingObstaclePrefab;
    public GameObject lyingDownObstaclePrefab;
    public float spawnRate = 3f;
    public float moveSpeed = 2f;
    public float spawnRangeY = 3f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 0f, spawnRate);
    }

    void SpawnObstacle()
    {
        float randomY = Random.Range(-spawnRangeY, spawnRangeY);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, 0f);

        GameObject selectedObstacle = Random.Range(0f, 1f) > 0.5f ? standingObstaclePrefab : lyingDownObstaclePrefab;

        GameObject obstacle = Instantiate(selectedObstacle, spawnPosition, Quaternion.identity);

        ObstacleMovement movement = obstacle.AddComponent<ObstacleMovement>();
        movement.moveSpeed = moveSpeed;
    }
}
