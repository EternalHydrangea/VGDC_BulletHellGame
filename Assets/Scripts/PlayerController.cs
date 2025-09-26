using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float normalSpeed = 5f;  // normal speed
    public float focusSpeed = 2f;   // slow "focus mode"

    private Vector2 moveDir;

    void Update()
    {
        // Move player
        //transform.Translate(moveDir * normalSpeed * Time.deltaTime);
        GetComponent<Rigidbody2D>().linearVelocity = moveDir * normalSpeed;

        // Keep player inside screen
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9.5f, 9.5f);
        pos.y = Mathf.Clamp(pos.y, -4.5f, 4.5f);
        transform.position = pos;
    }

    void OnMove(InputValue direction)
    {
        moveDir = direction.Get<Vector2>().normalized;
    }
}
