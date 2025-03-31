using UnityEngine;
using UnityEngine.SceneManagement;

public class FallingBlock : MonoBehaviour
{
    void Start()
    {
        // Automatically destroy after 5 seconds to prevent buildup
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Collision with player = Game Over
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Player hit! Reloading scene...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        // Collision with projectile = destroy both and score
        if (collision.collider.CompareTag("Projectile"))
        {
            FindObjectOfType<ScoreManager>().AddScore(10);
            Destroy(collision.gameObject); // Destroy projectile
            Destroy(gameObject);           // Destroy this block
        }

        // Collision with ground = destroy the block
        if (collision.collider.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
