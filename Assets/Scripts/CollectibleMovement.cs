using UnityEngine;

public class CollectibleMovement : MonoBehaviour
{
    public float moveSpeed; // Speed set by the spawner

    void Update()
    {
        // Move the collectible to the right
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        // Destroy the collectible if it goes off-screen (adjust the threshold as needed)
        if (transform.position.x > 10f) // Assuming the right edge of the screen is at x = 10
        {
            Destroy(gameObject);
        }
    }
}
