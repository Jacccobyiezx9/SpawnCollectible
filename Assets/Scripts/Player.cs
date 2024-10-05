using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager; // Reference to the GameManager

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            gameManager.IncreaseScore(1);
            Debug.Log("Collected");
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Hit an obstacle!");
            gameManager.GameOver();
        }
    }
}
