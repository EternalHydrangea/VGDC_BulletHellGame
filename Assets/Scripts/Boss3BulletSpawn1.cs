using UnityEngine;
using System.Runtime.CompilerServices;

public class Boss3BulletSpawn1 : MonoBehaviour
{
    public BouncingMovement bulletPrefab;
    public int GameTime = 0;
    int shootCycle;
    //reset the timer when the game starts
    void Start()
    {
        GameTime = 0;
        shootCycle = 0;
    }
    //spawn a bullet at the current position and rotation of the spawner
    void Spawn()
    {

        {
            if (shootCycle == 0)
            {
                BouncingMovement Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                //up
                Bullet.velocity = new Vector2(0f, 2f);
                shootCycle = 2;
            }
            else if (shootCycle == 2)
            {
                BouncingMovement Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                //down
                Bullet.velocity = new Vector2(0f, -2f);
                shootCycle = 0;
            }
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
