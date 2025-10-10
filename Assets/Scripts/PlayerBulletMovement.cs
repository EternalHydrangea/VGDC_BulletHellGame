using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class PlayerBulletMovement : MonoBehaviour
{
    // Initial velocity of the object
    public Vector2 velocity = new Vector2(5f, 5f);
    private float startTime;
    public float lifetime = 10f;
    void Start()
    {
        // give the object the initial velocity
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = velocity;
        startTime = Time.time;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        if (Time.time - startTime > lifetime)
        {
            Destroy(gameObject);
        }
    }
}
