using UnityEngine;

public class Boss4Lazer : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int GameTime = 0;
    float shootAngle;
    //reset the timer when the game starts
    void Start()
    {
        GameTime = 0;
        shootAngle = 0;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Spawn()
    {
        GameObject bullet; 
        bullet = Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, shootAngle));
        shootAngle += 10f;
        Destroy(bullet, 0.125f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GameTime += 1;
        if (GameTime % 2 == 0)
        {
            Spawn();
        }
        //Debug.Log(GameTime);
    }
}
