using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int score = 0; 
    public TMP_Text scoreText; 
    public GameObject gameOverScreen; 

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
