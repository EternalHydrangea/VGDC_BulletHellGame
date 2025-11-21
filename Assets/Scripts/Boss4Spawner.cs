using System;
using System.Collections;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor;
using UnityEngine.SceneManagement;


public class Boss4Spawner : MonoBehaviour
{
    public GameObject bulletPrefab1;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;
    public GameObject bulletPrefab4;
    public GameObject Goal;
    public float GameTime;
    public float minX = -4f;
    public float maxX = 4f;
    public float minY = -4f;
    public float maxY = 4f;
    int shootCycle;
    
    //reset the timer when the game starts
    void Start()
    {
        GameTime = 40f;
        shootCycle = 0;
        Spawn1();
    }
    //spawn a bullet at the current position and rotation of the spawner
    async Task Spawn1()
    {
        
        Debug.Log("Spawned Boss1 Bullet");
        GameObject spawner1 = Instantiate(bulletPrefab1, transform.position, transform.rotation);  
        Destroy(spawner1, 10f);
        // return new IEnumerator(1);
        await Task.Delay(10000);    
        GameObject spawner2 = Instantiate(bulletPrefab2, transform.position, transform.rotation);
        Destroy(spawner2, 10f);
        await Task.Delay(10000);
        GameObject spawner3 = Instantiate(bulletPrefab3, transform.position, transform.rotation);
        Destroy(spawner3, 10f);
        await Task.Delay(10000);
        DestroyAllObjectsWithTag("EnemyBullet");
        await Task.Delay(2000);
        GameObject spawner4 = Instantiate(bulletPrefab4, transform.position, transform.rotation);
        Destroy(spawner4, 10f);
        await Task.Delay(10000);
        DestroyAllObjectsWithTag("EnemyBullet");
        SpawnRandomObject();
        await Task.Delay(2000);
        SceneManager.LoadSceneAsync("Ending");
    }

    void DestroyAllObjectsWithTag(string tag)
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject obj in objects)
        {
            //Debug.Log("Destroyed Enemy Bullet");
            Destroy(obj);
        }
    }

    void SpawnRandomObject()
        {
            // Generate random coordinates within the defined ranges
            float randomX = UnityEngine.Random.Range(minX, maxX);
            float randomY = UnityEngine.Random.Range(minY, maxY);

            // Create a new Vector3 for the random position
            Vector2 randomPosition = new Vector2(randomX, randomY);

            Debug.Log("Spawned Goal at: " + randomPosition);

            // Instantiate the object at the random position with no rotation
            GameObject goal2 = Instantiate(Goal, randomPosition, Quaternion.identity);
        }
    //void Spawn2()
    //{
    //    GameObject spawner2 = Instantiate(bulletPrefab2, transform.position, transform.rotation);  
    //}


    //void Update()
    //{
    //    GameTime -= Time.deltaTime; // Decrease the countdown time
    //    ;
    
    //if ((int)GameTime == 30)
    //   {
    //      Spawn2();
     //}
        
    //}
    
}
