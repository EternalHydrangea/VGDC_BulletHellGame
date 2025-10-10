using System.Runtime.CompilerServices;
using UnityEngine;
//this file is use to spawn bullets at regular intervals
public class spawnBulletEnemy : MonoBehaviour

{
    public BouncingMovement bulletPrefab;
    public int GameTime = 0;
//reset the timer when the game starts
    void Start()
    {
        GameTime = 0;
    }
//spawn a bullet at the current position and rotation of the spawner
    void Spawn(){

        {
            BouncingMovement Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            //bottom left
            Bullet.velocity = new Vector2(4f, -5f);
            Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            //bottom right
            Bullet.velocity = new Vector2(-5f, -4f);
            Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            //top left
            Bullet.velocity = new Vector2(4f, 5f);
            Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            //up
            Bullet.velocity = new Vector2(0f, 2f);
            Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            //down
            Bullet.velocity = new Vector2(0f, -2f);
            Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            //left
            Bullet.velocity = new Vector2(-2f, 0f);
            Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            //right
            Bullet.velocity = new Vector2(2f, 0f);
            Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            //top right
            Bullet.velocity = new Vector2(-5f, 4f);
            
        }
    }
    // Increment the game time and spawn bullets at regular intervals
    void FixedUpdate()
    {
        GameTime += 1;
        if (GameTime % 50 == 0)
        {
            Spawn();
        }
        //Debug.Log(GameTime);
    }
    
}
