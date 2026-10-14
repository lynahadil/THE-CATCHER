
using System;

public static class GameEventManager
{
    public static event Action<int> OnScoreAdded;
    public static event Action<int> OnDamageTaken;
    public static event Action<int> OnScoreChanged;
    public static event Action<int> OnHealthChanged;
    public static event Action OnPlayerDeath;

    public static void TriggerScoreAdded(int points)
    {
        OnScoreAdded?.Invoke(points);
    }

    public static void TriggerDamageTaken(int damage)
    {
        OnDamageTaken?.Invoke(damage);
    }

    public static void TriggerScoreChanged(int score)
    {
        OnScoreChanged?.Invoke(score);
    }

    public static void TriggerHealthChanged(int health)
    {
        OnHealthChanged?.Invoke(health);
    }

    public static void TriggerPlayerDeath()
    {
        OnPlayerDeath?.Invoke();
    }
}
