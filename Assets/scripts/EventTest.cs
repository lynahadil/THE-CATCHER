
using UnityEngine;

public class EventTest : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameEventManager.TriggerScoreAdded(10);
        }
    }
}
