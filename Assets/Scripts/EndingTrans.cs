using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingTrans : MonoBehaviour
{
    //when this object collides with the player, transition to the ending scene.
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadSceneAsync("Ending");
        }
    }
}
