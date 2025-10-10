using UnityEngine;
using UnityEngine.SceneManagement; 

public class BossBehavior : MonoBehaviour
{
    public int health = 100;
    public int damage = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("PlayerBullet"))
            {
                health -= damage;
                Destroy(collision.gameObject);
                if (health <= 0)
                {
                    Destroy(gameObject);
                    SceneManager.LoadSceneAsync("Success");
                }
            }
        }
}
