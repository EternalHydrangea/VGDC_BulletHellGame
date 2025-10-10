using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float normalSpeed = 5f;  // normal speed
    public float focusSpeed = 2f;   // slow "focus mode"
    public float bulletSpeed = 10f;
    public PlayerBulletMovement bulletPrefab;
    private Vector2 moveDir;
    private Vector2 lastMoveDir;
    private float shootingTimer = 0f;

    public float shootingInterval = 0.5f; // Time between shots in seconds

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
            if (Time.time >= shootingTimer)
            {
                Shoot();
                shootingTimer = Time.time + shootingInterval;
            }
            
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

    void Shoot()
    {
        PlayerBulletMovement bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bullet.velocity = lastMoveDir * bulletSpeed;
        WaitForSeconds wait = new WaitForSeconds(2f);
    }

    
   
}
