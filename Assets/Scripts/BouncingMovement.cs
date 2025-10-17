using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class BouncingMovement : MonoBehaviour
{
    // Initial velocity of the object
    public Vector2 velocity = new Vector2(5f, 5f);
    private float startTime;
    public float lifetime = 4f;
    void Start()
    {
        // give the object the initial velocity
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = velocity;
        startTime = Time.time;  
    }

    // bounce off walls
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();  
            velocity = rb.linearVelocity = Vector2.Reflect(velocity, collision.contacts[0].normal);
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
