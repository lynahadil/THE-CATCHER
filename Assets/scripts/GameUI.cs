
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text scoreText;
    public Text healthText;
    public GameObject gameOverPanel;

    private void OnEnable()
    {
        GameEventManager.OnScoreChanged += UpdateScoreUI;
        GameEventManager.OnHealthChanged += UpdateHealthUI;
        GameEventManager.OnPlayerDeath += ShowGameOver;
    }

    private void OnDisable()
    {
        GameEventManager.OnScoreChanged -= UpdateScoreUI;
        GameEventManager.OnHealthChanged -= UpdateHealthUI;
        GameEventManager.OnPlayerDeath -= ShowGameOver;
    }

    private void Start()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
    }

    private void UpdateScoreUI(int score)
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    private void UpdateHealthUI(int health)
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + health;
        }
    }

    private void ShowGameOver()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }
    }
}
