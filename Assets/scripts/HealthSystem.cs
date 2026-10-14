
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;
    private bool isGameOver = false;

    private void OnEnable()
    {
        GameEventManager.OnDamageTaken += TakeDamage;
    }

    private void OnDisable()
    {
        GameEventManager.OnDamageTaken -= TakeDamage;
    }

    private void Start()
    {
        currentHealth = maxHealth;
        GameEventManager.TriggerHealthChanged(currentHealth);
    }

    private void TakeDamage(int damage)
    {
        if (isGameOver)
            return;

        currentHealth = Mathf.Max(currentHealth - damage, 0);
        GameEventManager.TriggerHealthChanged(currentHealth);

        Debug.Log("Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            isGameOver = true;
            GameEventManager.TriggerPlayerDeath();
            Time.timeScale = 0f;
            Debug.Log("GAME OVER!");
        }
    }
}

