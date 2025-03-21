using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    

    void Start()
    {

    }

    void Update()
    {
        float horizontal = 0.0f, vertical = 0.0f;
        Vector2 position = transform.position;

        if(Keyboard.current.leftArrowKey.isPressed || Input.GetKey(KeyCode.A))
        {
            horizontal = -0.1f;
        }
        else if(Keyboard.current.rightArrowKey.isPressed || Input.GetKey(KeyCode.D))
        {
            horizontal = 0.1f;
        }

        if(Keyboard.current.upArrowKey.isPressed || Input.GetKey(KeyCode.W))
        {
            vertical = 0.1f;
        }
        else if(Keyboard.current.downArrowKey.isPressed || Input.GetKey(KeyCode.S))
        {
            vertical = -0.1f;
        }

        position.x = position.x + 0.1f * horizontal;
        position.y = position.y + 0.1f * vertical;
        transform.position = position;
    }
}
