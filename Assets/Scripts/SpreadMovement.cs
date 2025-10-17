using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.Rendering.RenderGraphModule;

public class SpreadMovement : MonoBehaviour
{
   public BouncingMovement bulletPrefab;
    public int GameTime = 0;
    //reset the timer when the game starts
    void Start()
    {
        GameTime = 0;
    }
    //spawn a bullet at the current position and rotation of the spawner
    void Spawn()
    {
        BouncingMovement Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        //left
        Bullet.velocity = new Vector2(1f, 0f);
        Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        //right
        Bullet.velocity = new Vector2(-1f, 0f);
        Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        
    }
        // Increment the game time and spawn bullets at regular intervals
        void FixedUpdate()
    {
        GameTime += 1;
        if (GameTime % 25 == 0)
        {
            Spawn();
        }
        //Debug.Log(GameTime);
        Debug.Log(transform.position);
    }
}
