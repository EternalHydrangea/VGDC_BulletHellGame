using System.Runtime.CompilerServices;
using UnityEngine;
//this file is use to spawn bullets at regular intervals
public class spawnBulletEnemy : MonoBehaviour

{
    public GameObject bulletPrefab;
    public int GameTime = 0;
//reset the timer when the game starts
    void Start()
    {
        GameTime = 0;
    }
//spawn a bullet at the current position and rotation of the spawner
    void Spawn(){
        
        {
        GameObject Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
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
