using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        if (transform.position.x > 10f)
        {
            Destroy(gameObject);
        }
    }
}
