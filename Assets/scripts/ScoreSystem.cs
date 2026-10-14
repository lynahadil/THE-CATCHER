
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    private int totalScore = 0;

    private void OnEnable()
    {
        GameEventManager.OnScoreAdded += UpdateScore;
    }

    private void OnDisable()
    {
        GameEventManager.OnScoreAdded -= UpdateScore;
    }

    private void UpdateScore(int points)
    {
        totalScore += points;
        GameEventManager.TriggerScoreChanged(totalScore);
        Debug.Log("Score: " + totalScore);
    }
}
