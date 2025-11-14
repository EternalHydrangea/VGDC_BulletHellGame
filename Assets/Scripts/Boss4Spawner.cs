using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class Boss4Spawner : MonoBehaviour
{
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;
    public float GameTime;
    int shootCycle;
    //reset the timer when the game starts
    void Start()
    {
        GameTime = 40f;
        shootCycle = 0;
        Spawn1();
    }
    //spawn a bullet at the current position and rotation of the spawner
    void Spawn1()
    {
        GameObject spawner1 = Instantiate(bulletPrefab1, transform.position, transform.rotation);  
        Destroy(spawner1, 10f);
        // return new IEnumerator(1);
        
    }

    void Spawn2()
    {
        GameObject spawner2 = Instantiate(bulletPrefab2, transform.position, transform.rotation);  
    }


    void Update()
    {
        GameTime -= Time.deltaTime; // Decrease the countdown time
        ;
    
    if ((int)GameTime == 30)
       {
          Spawn2();
     }
        
    }
    
}
