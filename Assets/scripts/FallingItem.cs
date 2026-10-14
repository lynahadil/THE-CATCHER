
using UnityEngine;

public class FallingItem : MonoBehaviour
{
    public float fallSpeed = 3f;
    public bool isBomb = false;
    public int pointValue = 10;
    public int damage = 1;

    private void Update()
    {
        transform.position +=
            Vector3.down * fallSpeed * Time.deltaTime;

        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<BasketController>() == null)
        {
            return;
        }

        if (isBomb)
        {
            GameEventManager.TriggerDamageTaken(damage);
        }
        else
        {
            GameEventManager.TriggerScoreAdded(pointValue);
        }

        Destroy(gameObject);
    }
}

