using System.Runtime.CompilerServices;
using UnityEngine;

public class spawnBullet : MonoBehaviour

{
    public GameObject bulletPrefab;
    public int GameTime = 0;

    void Start()
    {
        GameTime = 0;
    }
    void Spawn(){
        
        {
        GameObject Bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
    void FixedUpdate()
    {
        GameTime += 1;
        if (GameTime % 50 == 0)
        {
            Spawn();
        }
        Debug.Log(GameTime);
    }
    
}
