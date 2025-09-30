using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float normalSpeed = 5f;  // normal speed
    public float focusSpeed = 2f;   // slow "focus mode"
    public float bulletSpeed = 10f;
    public BouncingMovement bulletPrefab;
    private Vector2 moveDir;
    private Vector2 lastMoveDir;

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



        if (Keyboard.current.spaceKey.isPressed)
        {
            // Call your shooting function here
            BouncingMovement bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.velocity = lastMoveDir * bulletSpeed;
        }
    }

    void OnMove(InputValue direction)
    {
        moveDir = direction.Get<Vector2>().normalized;
        if (moveDir != Vector2.zero)
        {
            lastMoveDir = moveDir;
        }
    }

    
   
}
