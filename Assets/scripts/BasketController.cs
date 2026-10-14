
using UnityEngine;
using UnityEngine.InputSystem;

public class BasketController : MonoBehaviour
{
    public float speed = 8f;
    public float limit = 7.5f;

    void Update()
    {
        float movement = 0f;

        if (Keyboard.current != null)
        {
            if (Keyboard.current.leftArrowKey.isPressed ||
                Keyboard.current.aKey.isPressed)
            {
                movement = -1f;
            }
            else if (Keyboard.current.rightArrowKey.isPressed ||
                     Keyboard.current.dKey.isPressed)
            {
                movement = 1f;
            }
        }

        Vector3 position = transform.position;
        position.x += movement * speed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -limit, limit);
        transform.position = position;
    }
}
