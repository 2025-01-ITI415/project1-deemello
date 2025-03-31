using UnityEngine;

public class SecretCollectible : MonoBehaviour
{
    public int scoreValue = 100;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<ScoreManager>().AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
